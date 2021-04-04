using BikeRental.Classes;
using BikeRental.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BikeRental.ViewModels
{
    class BikeWindowViewModel : BaseWindowViewModel
    {
        public Bikes SelectedBike { get; set; }
        public IEnumerable<GenderOptions> GenderComboBox { get; set; }
        public RelayCommand RemoveBikeClick { get; set; }
        public BikeRentalDb db  { get; set; } = new BikeRentalDb();
        public ObservableCollection<Bikes> ListOfBikes { get; set; }
        public BikeWindowViewModel()
        {
            db.Bikes.Load();
            RemoveBikeClick = new RelayCommand(RemoveBike);
            GenderComboBox = Enum.GetValues(typeof(GenderOptions)).Cast<GenderOptions>();
        }

        public void RemoveBike(object a)
        {
            db.Bikes.Local.Remove(SelectedBike);
            db.SaveChanges();
        }
    }
}
