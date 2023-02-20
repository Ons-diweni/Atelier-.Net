using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCoree.domain
{
        public class Flight
    {
        //Properties
        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public int Flightid { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimaedDuration { get; set; }

        //Methodes
        public override string? ToString()
        {
            return $"{Destination}, {Departure} , {FlightDate} , {Flightid} , {EffectiveArrival} , {EstimaedDuration}";
        }

        public Flight()
        { } 

        //Associations
        public Plane plane { get; set; }


        public IList<Passenger> Passengers { get; set;}

    }
}
