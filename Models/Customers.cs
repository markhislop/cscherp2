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
        public string FirstName { get; set; }

        public string Lastname { get; set; }

        public string Email { get; set; }

        public string Zip { get; set; }

        public int StreetNumber { get; set; }

        public string Street { get; set; }

        public string City { get; set; }
    }
}
