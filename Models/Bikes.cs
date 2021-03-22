using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental.Models
{
    class Bikes
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public GenderOptions Gender { get; set; }
        public double Price { get; set; }
    }

    public enum GenderOptions
    {
        Male,
        Female
    }
}
