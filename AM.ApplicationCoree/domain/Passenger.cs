using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCoree.domain
{
    public class Passenger
    {

        //Properties
        public int PassengerId { get; set; }
        public DateTime BirthDate { get; set; }
        public int PassportNumber { get; set; }
        public string EmailAdress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TelNumber { get; set; }

     
       public IList<Flight> Flights { get; set; }

        //Mèthodes
        public override string? ToString()
        {
            return $"{BirthDate}, {PassportNumber} , {EmailAdress} , {FirstName} , {LastName} , {TelNumber}";
        }

        public Passenger()
        {
        }


        //Polymorphisme par signature ( Surcharge ) 

        public bool CheckProfile(string nom, string prenom)
        { return (this.FirstName == nom && this.LastName == prenom); }


        /* public bool CheckProfile(string nom, string prenom , string email)
        { return (this.FirstName == nom && this.LastName == prenom && this.EmailAdress == email); } */

        public bool CheckProfile (string nom, string prenom , string? email =null )
        {
            if(email!=null)
            return (this.FirstName == nom && this.FirstName == prenom && this.EmailAdress == email);
            else return (this.FirstName == nom && this.FirstName == prenom );
        }

        //Méthodes à redéfinir dans les classes filles de cette classe 
        public virtual void PassengerType()
        {
            System.Console.WriteLine("I am a Passenger ");
        }


    }
}
