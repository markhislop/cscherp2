using BikeRental.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental.ViewModels
{
    class StorageViewModel
    {
        public static ObservableCollection<Bikes> ListOfBikes { get; set; }
        public static ObservableCollection<Stores> ListOfStores { get; set; }
        public static bool HasRun { get; set; } = false;

        public static void RunStorage()
        {
            if (HasRun == false)
            {
                ListOfBikes = new ObservableCollection<Bikes>()
                {
                    new Bikes
                    {
                        Model = "Fonk 3v",
                        Brand = "Batavus",
                        Price = 579.99,
                        Gender = GenderOptions.Male
                    },
                    new Bikes
                    {
                        Model = "Vento",
                        Brand = "Gazelle",
                        Price = 669.79,
                        Gender = GenderOptions.Male
                    },
                    new Bikes
                    {
                        Model = "Chamonix",
                        Brand = "Gazelle",
                        Price = 899.48,
                        Gender = GenderOptions.Female
                    }
                };

                ListOfStores = new ObservableCollection<Stores>()
                {
                    new Stores
                    {
                        Address = "Sesaamstraat 123",
                        Place = "Teletubbyland",
                        Capacity = 10,
                        Staff = 4
                    },
                    new Stores
                    {
                        Address = "Verzetslaan 6",
                        Place = "Verzetswijk",
                        Capacity = 30,
                        Staff = 6
                    },
                    new Stores
                    {
                        Address = "Poelenburg 131",
                        Place = "Zaandam",
                        Capacity = 100,
                        Staff = 10
                    },
                    new Stores
                    {
                        Address = "Anne Franklaan 161",
                        Place = "Amsterdam",
                        Capacity = 500,
                        Staff = 45
                    }
                };
                HasRun = true;
            }
        }
    }
}
