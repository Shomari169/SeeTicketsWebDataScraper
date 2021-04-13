using HtmlAgilityPack;
using SeeTicketsWebDataScraper.DataTypes;
using SeeTicketsWebDataScraper.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SeeTicketsWebDataScraper.Engine
{
    public class ScrapeData
    {
        public static async Task<List<SeeTicketUserDataSet>> ScrapeArtistNames(string url)
        {
            using var client = new HttpClient();

            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var htmlBody = await response.Content.ReadAsStringAsync();
                var htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(htmlBody);

                var artistScripts = htmlDocument.DocumentNode.SelectNodes("//span[@class='event-title']").ToList();

                var listOfArtistNames = new List<SeeTicketUserDataSet>();

                foreach (var name in artistScripts)
                {
                    listOfArtistNames.Add(new SeeTicketUserDataSet { EventName = name.InnerText });
                }
                return listOfArtistNames;
            }
            else
            {
                throw new Exception(Message.Exception + $"{response.StatusCode} - {response.ReasonPhrase} - {response.RequestMessage}");
            }
        }

        public static async Task<List<SeeTicketUserDataSet>> ScrapeVenuesScript(string url)
        {
            using var client = new HttpClient();

            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {

                var htmlBody = await response.Content.ReadAsStringAsync();
                var htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(htmlBody);

                var venueScripts = htmlDocument.DocumentNode.SelectNodes("//span[@class='g-blocklist-action']").ToList();

                var listOfVenues = new List<SeeTicketUserDataSet>();
                foreach (var venue in venueScripts)
                {
                    listOfVenues.Add(new SeeTicketUserDataSet { Status = venue.InnerText });
                }
                return listOfVenues;
            }
            else
            {
                throw new Exception(Message.Exception + $"{response.StatusCode} - {response.ReasonPhrase} - {response.RequestMessage}");
            }
        }

        public static async Task<List<SeeTicketUserDataSet>> ScrapeDatesScript(string url)
        {
            using var client = new HttpClient();

            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var htmlBody = await response.Content.ReadAsStringAsync();
                var htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(htmlBody);

                var dateScripts = htmlDocument.DocumentNode.SelectNodes("//time[@datetime]").ToList();

                var listOfDates = new List<SeeTicketUserDataSet>();
                foreach (var date in dateScripts)
                {
                    listOfDates.Add(new SeeTicketUserDataSet { EventDate = date.InnerText });
                }
                return listOfDates;
            }
            else
            {
                throw new Exception(Message.Exception + $"{response.StatusCode} - {response.ReasonPhrase} - {response.RequestMessage}");
            }
        }

    }
}
