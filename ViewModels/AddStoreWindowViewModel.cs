using BikeRental.Classes;
using BikeRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BikeRental.ViewModels
{
    class AddStoreWindowViewModel : BaseWindowViewModel
    {
        public string Address { get; set; }
        public string Place { get; set; }
        public int Capacity { get; set; }
        public int Staff { get; set; }
        public RelayCommand AddStoreClick { get; set; }

        public AddStoreWindowViewModel()
        {
            AddStoreClick = new RelayCommand(AddStore);
            Address = "";
            Place = "";
            Capacity = 0;
            Staff = 0;
        }

        public void AddStore(object a)
        {
            if (Address == "" || Place == "" || Capacity <= 0 || Staff <= 0)
            {
                MessageBox.Show("Vul geldige gegevens in");
                return;
            }
            else
            {
                Stores store = new Stores()
                {
                    Address = Address,
                    Place = Place,
                    Capacity = Capacity,
                    Staff = Staff
                };
                // ListOfStores.Add(store);
                MessageBox.Show("Store is toegevoegd");
            };
        }
    }
}
