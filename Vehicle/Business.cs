using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Business
    {
        public static void CreateBus()
        {
            Console.Write("Please enter Passenger count of bus: ");
            byte PassangerCount = byte.Parse(Console.ReadLine());
            Console.Write("Please enter Color of bus: ");
            string Colour = checkString(Console.ReadLine());
            Console.Write("Please enter Max speed of bus: ");
            string Maxspeed = checkString(Console.ReadLine());
            Console.Write("Please enter Brand of bus: ");
            string Brand = checkString(Console.ReadLine());
            Console.Write("Please enter Model of bus: ");
            string Model = checkString(Console.ReadLine());
            Bus bus1 = new Bus(PassangerCount, Colour, Maxspeed, Brand, Model);
            bus1.ReturnAllInformation();
           
        }

        public static string checkString(string a)
        {
            while (String.IsNullOrEmpty(a)|| String.IsNullOrWhiteSpace(a))
            {
                Console.WriteLine("please, don't enter null or empty");
                a = Console.ReadLine();
            }
            return a;
        }
        
    }
}
