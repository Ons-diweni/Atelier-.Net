using System.Numerics;
using System.Runtime.CompilerServices;
using AM.ApplicationCoree;
using AM.ApplicationCoree.domain;
using AM.ApplicationCoree.Services;
using Plane = AM.ApplicationCoree.domain.Plane;

namespace AM.UI.Console2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////instanciation d'objet en utilisant les initialiseurs d'objet
            //ApplicationCoree.domain.Plane plane = new Plane() { Capacity=122 , ManufactureDate= new DateTime(2008, 3, 1) , PlanId=1 , PlaneType=PlaneType.Boing};

            //Plane plane2 = new Plane(12 , new DateTime(2008, 3, 1) , PlaneType.Airbus);


            //Passenger p1 = new Traveller();
            //Passenger p2 = new Staff();
            //p1.PassengerType();
            //p2.PassengerType();

            //Passenger p = new Passenger();
            //p.PassengerType();



            //ServicesFlight serviceFlight = new ServicesFlight();
            //serviceFlight.Flights = TestData.Flights;


            //serviceFlight.DestinationGroupedFlights();
            //serviceFlight.DurationAverage("Paris");
            //serviceFlight.OrderedDurationFlight();

            int x = 10;
            Console.WriteLine(x.Add(8));





        }
    }
}