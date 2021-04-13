using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SeeTicketsWebDataScraper.Connection;
using SeeTicketsWebDataScraper.DataTypes;
using SeeTicketsWebDataScraper.Engine;
using SeeTicketsWebDataScraper.Messages;

namespace SeeTicketsWebDataScraper
{
    class Program
    {
        static async Task Main(string[] args)
        {

           var tasks = new List<Task<List<SeeTicketUserDataSet>>>();

            var url = UrlConnection.BaseUrl;

            tasks.AddRange(new List<Task<List<SeeTicketUserDataSet>>>
            {
               ScrapeData.ScrapeArtistNames(url),
               ScrapeData.ScrapeVenuesScript(url),
               ScrapeData.ScrapeDatesScript(url)
            });
            
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
                Console.WriteLine(Message.HTMLPageError, ex.ToString());
            }
         
        }

    }
}