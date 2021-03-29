using System;
using System.Data.Entity;
using System.Linq;

namespace BikeRental.Models
{
    public class BikeRental : DbContext
    {
        public BikeRental() : base("name=BikeRental")
        {
        }

        public virtual DbSet<Bikes> Bikes { get; set; }
    }
}