using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeeTicketsWebDataScraper.DataTypes
{
   public class SeeTicketUserDataSet
   {
        public string EventName { get; set; }
        public string Venue { get; set; }
        public string EventDate { get; set; }

        /// <summary>
        /// Display this user in the console
        /// </summary>
        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"-------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(JsonConvert.SerializeObject($"Artist Name: {EventName}"));
            Console.WriteLine($"Venues: {Venue}");
            Console.WriteLine($"Images: {EventDate}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"-------------------------------------");
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
   }
}
