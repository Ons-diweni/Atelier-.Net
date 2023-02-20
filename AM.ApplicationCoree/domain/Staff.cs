using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCoree.domain
{
    public class Staff:Passenger
    {

        //Properties
      
        public DateTime EmployementDate { get; set; }
        public string Function { get; set; }
        public float Salary { get; set; }


        //Mèthodes
        public override string? ToString()
        {
            return base.ToString + $"{EmployementDate}, {Function} , {Salary}";
        }

        public Staff() { }

        override public void PassengerType()
        {
          //  base.PassengerType(); 
           System.Console.WriteLine("I am a Staff Member ");
        }


    }
}
