using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Vehicle
    {
        protected string Brand;
        protected string Model;
        protected string Colour;
        protected string Maxspeed;

        public Vehicle()
        {
            Console.WriteLine("Vehicle created");
        }
        public Vehicle(string brand,string model):this()
        {
            Brand = brand;
            Model = model;
        }
        public Vehicle(string colour,string maxspeed,string brand,string model):this(brand,model)
        {
            Colour = colour;
            Maxspeed = maxspeed;
        }
        public virtual void ReturnAllInformation()
        {
            Console.WriteLine(Brand+Model+Colour+Maxspeed);
        }
        
    }
}
