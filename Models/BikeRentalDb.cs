using System;
using System.Data.Entity;
using System.Linq;

namespace BikeRental.Models
{
    public class BikeRentalDb : DbContext
    {
        public BikeRentalDb() : base("name=BikeRentalDb")
        {
        }

        public virtual DbSet<Bikes> Bikes { get; set; }
        public virtual DbSet<Stores> Stores { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Reservations> Reservations { get; set; }
    }
}