using AM.ApplicationCoree.domain;
using AM.ApplicationCoree.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCoree.Services
{
    public class ServicesFlight : IServiceFlight
    {

        public List<Flight> Flights { get; set; } = new List<Flight>();

        public void DestinationGroupedFlights()
        {
            var GroupsByDes = Flights.GroupBy(f => f.Destination);
            foreach (var group in GroupsByDes) 
            {
                {
                    Console.WriteLine("Destination " + group.First().Destination);
                    foreach (var f in group) { Console.WriteLine("Decollage :" + f.FlightDate); }
                }
            }
        }

        public float DurationAverage(string destination)
        {
            var FlightsByDes = Flights.Where(f => f.Destination ==  destination);
            int totaleD = 0;
            foreach (var item in FlightsByDes)
            {
                totaleD = totaleD + item.EstimaedDuration; 
            }
            Console.WriteLine(totaleD / FlightsByDes.LongCount());
            return totaleD/FlightsByDes.LongCount(); 

        }

        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Destination":
                    {
                        var result = Flights.Where(f => f.Destination == filterValue).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "Departure":
                    {
                        var result = Flights.Where(f => f.Departure == filterValue).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "FlightDate":
                    {
                        var result = Flights.Where(f => f.FlightDate == DateTime.Parse(filterValue)).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "Flightid":
                    {
                        var result = Flights.Where(f => f.Flightid == int.Parse(filterValue)).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "EffectiveArrival":
                    {
                        var result = Flights.Where(f => f.EffectiveArrival == DateTime.Parse(filterValue)).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
                case "EstimaedDuration":
                    {
                        var result = Flights.Where(f => f.EstimaedDuration == int.Parse(filterValue)).ToList();
                        foreach (var f in result)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;
            }
        }



        public List<Flight> OrderedDurationFlight()
        {
            var FlightsOrd = Flights.OrderByDescending(f => f.EstimaedDuration).ToList();
            return FlightsOrd; 
        }

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            return Flights.Count(f=>  (f.FlightDate >= startDate) && (f.FlightDate < startDate.AddDays(7)));
        }

        public IEnumerable<Traveller> SeniorTraveller(Flight flight)
        {
            var seniorTrav = flight.Passengers.OfType<Traveller>().OrderByDescending(p=>p.BirthDate).Take(3);
            return  seniorTrav; 
        }

        public void ShowFlightDetails(Plane plane)
        {
            var a = plane.Flights.Select(f=> new { f.Destination, f.FlightDate });      
            foreach (var item in a)
            { Console.WriteLine(item.Destination + item.FlightDate);}
        }


        public Action<Plane> FlightDetailsDel { get; set; }
        public Func<string,double> DurationAverageDel { get; set; }



        public  ServicesFlight () {
            //FlightDetailsDel = ShowFlightDetails;
            //DurationAverageDel = DurationAverage;

            FlightDetailsDel =  plane => {
                var a = plane.Flights.Select(f => new { f.Destination, f.FlightDate });
                foreach (var item in a)
                { Console.WriteLine(item.Destination + item.FlightDate); }
            };

            DurationAverageDel = destination => {
                var FlightsByDes = Flights.Where(f => f.Destination == destination);
                int totaleD = 0;
                foreach (var item in FlightsByDes)
                {
                    totaleD = totaleD + item.EstimaedDuration;
                }
                Console.WriteLine(totaleD / FlightsByDes.LongCount());
                return totaleD / FlightsByDes.LongCount();

            }
;
        }

    }
}
