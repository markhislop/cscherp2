using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental.Models
{
    public class Reservations
    {
        public int Id { get; set; }
        public Customers Customer { get; set; }
        public Bikes Bike { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Stores PickupStore { get; set; }
    }
}
