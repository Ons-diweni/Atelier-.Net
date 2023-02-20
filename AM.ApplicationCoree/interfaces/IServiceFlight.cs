using AM.ApplicationCoree.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCoree.interfaces
{
    public interface IServiceFlight
    {

        public void GetFlights(string filterType, string filterValue);
        public void ShowFlightDetails(Plane plane);
        public int ProgrammedFlightNumber(DateTime startDate);
        public float DurationAverage(string destination);
        public List<Flight> OrderedDurationFlight();
        public IEnumerable<Traveller> SeniorTraveller(Flight flight);
        public void DestinationGroupedFlights();


    }
}
