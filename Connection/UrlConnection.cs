using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

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
