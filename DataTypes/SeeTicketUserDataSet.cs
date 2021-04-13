using Newtonsoft.Json;
using System;


namespace SeeTicketsWebDataScraper.DataTypes
{
   public class SeeTicketUserDataSet
   {
        public string EventName { get; set; }
        public string Status { get; set; }
        public string EventDate { get; set; }

        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"-------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Artist Name: {EventName}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine($"Dates: {EventDate}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"-------------------------------------");
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
   }
}
