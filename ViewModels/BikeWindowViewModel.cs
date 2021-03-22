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
    class BikeWindowViewModel : BaseWindowViewModel
    {
        public Bikes SelectedBike { get; set; }
        public IEnumerable<GenderOptions> GenderComboBox { get; set; }
        public RelayCommand RemoveBikeClick { get; set; }

        public BikeWindowViewModel()
        {
            RemoveBikeClick = new RelayCommand(RemoveBike);
            GenderComboBox = Enum.GetValues(typeof(GenderOptions)).Cast<GenderOptions>();
        }

        public void RemoveBike(object a)
        {
            ListOfBikes.Remove(SelectedBike);
        }
    }
}
