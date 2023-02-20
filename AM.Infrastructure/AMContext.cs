using AM.ApplicationCoree.domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    internal class AMContext : DbContext 
    {

        public DbSet<Traveller> Travellers { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Staff> Staff { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source= (localdb)\\mssqllocaldb;" +
                "initial catalog=OnsDiweni; integrated security=true");
        }
    }
}
