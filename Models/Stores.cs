using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental.Models
{
    public class Stores
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Place { get; set; }
        public int Capacity { get; set; }
        public int Staff { get; set; }
        public virtual List<Bikes> AvailableBikes { get; set; }

    }
}
