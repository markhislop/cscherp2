using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental.Models
{
    public class Bikes
    {
        public int Id { get; set; }
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
