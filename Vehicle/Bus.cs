using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Bus:Vehicle
    {
        public byte PassengerCount;
        public Bus(byte passenger,string colour, string maxspeed, string brand, string model) :base(colour, maxspeed, brand, model)
        {
            PassengerCount = passenger;
        }
        public override void ReturnAllInformation()
        {
            Console.Write("Bus's passengercount - " + PassengerCount +"  Colour of Bus - "+Colour+"  Maxspeed of Bus -  "+Maxspeed+"  Brand of Bus -  "+Brand+"  Model of Bus - "+Model);      
        }
    }
}
