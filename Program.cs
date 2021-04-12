using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SeeTicketsWebDataScraper.Connection;
using SeeTicketsWebDataScraper.DataTypes;
using SeeTicketsWebDataScraper.Messages;

namespace SeeTicketsWebDataScraper
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // receive a profile name
           var tasks = new List<Task<List<SeeTicketUserDataSet>>>();
       
           var url = "https://www.seetickets.com/search?BrowseOrder=Relevance&q=&s=&se=false&c=3&dst=&dend=&l";

                tasks.Add(ScrapeSeeTickets(url));

            try
            {
                var seeTicketUser = await Task.WhenAll(tasks);
                foreach (var ui in seeTicketUser)
                {
                    for (int i = 0; i < ui.Count; i++)
                    {
                        SeeTicketUserDataSet item = ui[i];
                        item.Display();
                    };
                
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public static async Task<List<SeeTicketUserDataSet>> ScrapeSeeTickets(string url)
        {
            using var client = new HttpClient();
 
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                // create html document
                var htmlBody = await response.Content.ReadAsStringAsync();
                var htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(htmlBody);

                // select script tags
                var artistScripts = htmlDocument.DocumentNode.SelectNodes("//span[@class='event-title']").ToList();
                var venueScripts = htmlDocument.DocumentNode.SelectNodes("//span[@class='g-blocklist-action']").ToList();
                var dateScripts = htmlDocument.DocumentNode.SelectNodes("//time[@datetime]").ToList();

                var zipScripts = artistScripts.Zip(venueScripts, (n, p) => new { n, p }).Zip(dateScripts, (t, c) =>
                new { Artist = t.n, Venue = t.p, Date = c });

         
                var seeTicketUser = new List<string>();
                foreach (var item in zipScripts)
                {
                   var list = string.Join(",", new SeeTicketUserDataSet {EventName = item.Artist.InnerText, EventDate = item.Date.InnerText, Venue = item.Venue.InnerText });
                    seeTicketUser.Add(list);
                }
                return seeTicketUser.OfType<SeeTicketUserDataSet>().ToList();

            }
            else
            {
                throw new Exception(Message.Exception + $"{response.StatusCode} - {response.ReasonPhrase} - {response.RequestMessage}");
            }
        }

  
    }
}