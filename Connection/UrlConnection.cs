<<<<<<< HEAD
﻿using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
=======
﻿using System;
using System.Collections.Generic;
>>>>>>> 7d50420bd64cbd2a8e678d5e7bfe47f8ab988d5f
using System.Text;

namespace SeeTicketsWebDataScraper.Connection
{
    public static class  UrlConnection
    {
<<<<<<< HEAD
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
=======
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
>>>>>>> 7d50420bd64cbd2a8e678d5e7bfe47f8ab988d5f
    }
}
