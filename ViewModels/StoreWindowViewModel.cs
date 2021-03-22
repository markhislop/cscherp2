using BikeRental.Classes;
using BikeRental.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental.ViewModels
{
    class StoreWindowViewModel : BaseWindowViewModel
    {
        public Stores SelectedStore { get; set; }
        public RelayCommand RemoveStoreClick { get; set; }

        public StoreWindowViewModel()
        {
            RemoveStoreClick = new RelayCommand(RemoveStore);
        }

        public void RemoveStore(object a)
        {
            ListOfStores.Remove(SelectedStore);
        }
    }
}
