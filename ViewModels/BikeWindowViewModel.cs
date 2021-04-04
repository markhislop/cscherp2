using BikeRental.Classes;
using BikeRental.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows;

namespace BikeRental.ViewModels
{
    class BikeWindowViewModel : BaseWindowViewModel
    {
        public Bikes SelectedBike { get; set; }
        public IEnumerable<GenderOptions> GenderComboBox { get; set; }
        public RelayCommand RemoveBikeClick { get; set; }
        public RelayCommand EditBikeClick { get; set; }
        public BikeRentalDb db  { get; set; } = new BikeRentalDb();
        public BikeWindowViewModel()
        {
            db.Bikes.Load();
            RemoveBikeClick = new RelayCommand(RemoveBike);
            EditBikeClick = new RelayCommand(EditBike);
            GenderComboBox = Enum.GetValues(typeof(GenderOptions)).Cast<GenderOptions>();
        }

        public void EditBike(object a)
        {
            if (SelectedBike != null)
            {
                Bikes dbBike = db.Bikes.Local.First(bike => bike.Id == SelectedBike.Id);
                PropertyCopy.Copy(dbBike, SelectedBike);
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Er is geen bike gekozen!!!");
            }

        }

        public void RemoveBike(object a)
        {
            if (SelectedBike != null)
            {
                db.Bikes.Local.Remove(SelectedBike);
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Er is geen bike gekozen!!!");
            }
        }
    }
}
