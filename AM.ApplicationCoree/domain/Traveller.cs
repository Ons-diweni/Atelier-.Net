using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCoree.domain
{
    public class Traveller : Passenger
    {
         
        //Properties
        public string HealthInformation { get; set; }
        public string Nationality { get; set; }


        //Mèthodes
        public Traveller() { }
        public override string? ToString()
        {
            return base.ToString() + $"{HealthInformation}, {Nationality}";
        }


        override public void PassengerType()
        {
            base.PassengerType() ;
            System.Console.WriteLine("I am a Traveller ");
        }



    }
}
