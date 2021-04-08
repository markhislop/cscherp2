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
    class AddBikeWindowViewModel : BaseWindowViewModel
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public GenderOptions Gender { get; set; }
        public double Price { get; set; }
        public RelayCommand AddBikeClick { get; set; }
        public IEnumerable<GenderOptions> GenderComboBox { get; set; }
        public BikeRentalDb db { get; set; } = new BikeRentalDb();

        public AddBikeWindowViewModel()
        {
            AddBikeClick = new RelayCommand(AddBike);
            GenderComboBox = Enum.GetValues(typeof(GenderOptions)).Cast<GenderOptions>();
            Model = "";
            Brand = "";
            Price = 0;
        }

        public void AddBike(object a)
        {
            if (Model == "" || Brand == "" || Price <= 0)
            {
                MessageBox.Show("Vul geldige gegevens in");
                return;
            }
            else
            {
                Bikes bike = new Bikes()
                {
                    Model = Model,
                    Brand = Brand,
                    Gender = Gender,
                    Price = Price
                };
                db.Bikes.Add(bike);
                db.SaveChanges();
                MessageBox.Show("Bike is toegevoegd");
            };
        }
    }
}
