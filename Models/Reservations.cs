using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental.Models
{
    class Reservations
    {
        public Customers Customer { get; set; }
        public Bikes Bike { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Stores PickupStore { get; set; }
        public Stores DropoffStore { get; set; }
    }
}
