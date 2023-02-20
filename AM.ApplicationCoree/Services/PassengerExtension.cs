using AM.ApplicationCoree.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCoree.Services
{
     public static class PassengerExtension 
    {  public static void FullNamePassenger (this Passenger passenger) 
        { passenger.FirstName = passenger.FirstName[0].ToString().ToUpper() + passenger.FirstName.Substring(1);
          passenger.FirstName = passenger.LastName[0].ToString().ToUpper() + passenger.LastName.Substring(1);
        }
    }
}
