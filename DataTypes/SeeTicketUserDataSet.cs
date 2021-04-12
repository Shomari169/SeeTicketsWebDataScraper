using Newtonsoft.Json;
using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Threading.Tasks;
=======
using System.Text;
>>>>>>> 7d50420bd64cbd2a8e678d5e7bfe47f8ab988d5f

namespace SeeTicketsWebDataScraper.DataTypes
{
   public class SeeTicketUserDataSet
   {
        public string EventName { get; set; }
<<<<<<< HEAD
        public string Status { get; set; }
        public string EventDate { get; set; }

        /// <summary>
        /// Display this scraped data in the console
=======
        public string Venue { get; set; }
        public string EventDate { get; set; }

        /// <summary>
        /// Display this user in the console
>>>>>>> 7d50420bd64cbd2a8e678d5e7bfe47f8ab988d5f
        /// </summary>
        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"-------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
<<<<<<< HEAD
            Console.WriteLine($"Artist Name: {EventName}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine($"Dates: {EventDate}");
=======
            Console.WriteLine(JsonConvert.SerializeObject($"Artist Name: {EventName}"));
            Console.WriteLine($"Venues: {Venue}");
            Console.WriteLine($"Images: {EventDate}");
>>>>>>> 7d50420bd64cbd2a8e678d5e7bfe47f8ab988d5f
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"-------------------------------------");
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
   }
}
