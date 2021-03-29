using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental.Models
{
    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GenderOptions Gender { get; set; }
        public string Email { get; set; }
    }
}
