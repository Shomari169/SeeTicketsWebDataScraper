using System;
using System.Collections.Generic;
using System.Text;

namespace SeeTicketsWebDataScraper.Engine
{
    class ApproachDidNotWork
    {
        // The reason why I left this block of commented code in here to show some of the thought process I went
        // thorugh which can be discussed should I progress to the next stage of interview.

        // The issus was I wanted to have one method where everything happens and this will mean less code
        // but I didnt think I had not all the time ti figure it out as i was not
        // able to cast string type to my object type - spent the long
        // trying to figure it out so i took a different approach by breaking my approach into three smaller methods.
        // I will revist this at some point.





        //public static async Task<List<SeeTicketUserDataSet>> ScrapeSeeTickets(string url)
        //{
        //    using var client = new HttpClient();

        //    var response = await client.GetAsync(url);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        // create html document
        //        var htmlBody = await response.Content.ReadAsStringAsync();
        //        var htmlDocument = new HtmlDocument();
        //        htmlDocument.LoadHtml(htmlBody);

        //        // select script tags
        //        var artistScripts = htmlDocument.DocumentNode.SelectNodes("//span[@class='event-title']").ToList();
        //        var venueScripts = htmlDocument.DocumentNode.SelectNodes("//span[@class='g-blocklist-action']").ToList();
        //        var dateScripts = htmlDocument.DocumentNode.SelectNodes("//time[@datetime]").ToList();

        //        var zipScripts = artistScripts.Zip(venueScripts, (n, p) => new { n, p }).Zip(dateScripts, (t, c) =>
        //        new { Artist = t.n, Venue = t.p, Date = c });


        //        var seeTicketUser = new List<SeeTicketUserDataSet>();
        //        foreach (var item in zipScripts)
        //        {
        //            var list = string.Join(",", new SeeTicketUserDataSet
        //            {
        //                EventName = item.Artist.InnerText,
        //                EventDate = item.Date.InnerText,
        //                Venue = item.Venue.InnerText
        //            });


        //            Console.WriteLine(list);
        //            //list.Cast<SeeTicketUserDataSet>();
        //            //seeTicketUser.Add(list);
        //        }
        //        return seeTicketUser;

        //    }
        //    else
        //    {
        //        throw new Exception(Message.Exception + $"{response.StatusCode} - {response.ReasonPhrase} - {response.RequestMessage}");
        //    }
        //}


    }
}
