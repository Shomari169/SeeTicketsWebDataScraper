using System;
using System.Net.Http;

namespace SeeTicketsWebDataScraper.Connection
{
    public static class  UrlConnection
    {

        private static string _webUrl = "https://www.seetickets.com/search?BrowseOrder=Relevance&q=&s=&se=false&c=3&dst=&dend=&l";

        public static string BaseUrl
        {
            get {return _webUrl;}
            set
            {
                _ = new HttpClient
                {
                    BaseAddress = new Uri(_webUrl)
                };
            }
        }
    }
}
