using System;
using System.Collections.Generic;
using System.Text;

namespace SeeTicketsWebDataScraper.Connection
{
    public static class  UrlConnection
    {
        private static string _webUrl;
            
            
        public static string BaseUrl
        {
            get { return _webUrl; }
            set 
            {
                _webUrl = /*value;*/
                /*var callBackUrl = _webUrl +*/ "https://www.seetickets.com/search?BrowseOrder=Relevance&q=&s=&se=false&c=3&dst=&dend=&l";
            }
        }  
    }
}
