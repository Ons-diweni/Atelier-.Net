using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCoree.domain
{
    public class Plane
    {
      

        //Attributs de classe 
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }

        public override string? ToString()
        {
            return $"{Capacity}, {ManufactureDate} , {PlaneId} , {PlaneType}";
        }

        //Constructeur par dèfaut
        public Plane() {}


        //Constructeur paramétré
        public Plane(int capacity, DateTime manufactureDate, PlaneType planeType)
        {
            Capacity = capacity;
            ManufactureDate = manufactureDate;
            PlaneType = planeType;
        }



        //Assoiations 
        public LinkedList<Flight> Flights { get; set;}

       

    }
}
