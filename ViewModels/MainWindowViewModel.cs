using BikeRental.Classes;
using BikeRental.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental.ViewModels
{
    class MainWindowViewModel : BaseWindowViewModel, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public RelayCommand OpenWelcomePageClick { get; set; }
        public RelayCommand OpenStoresPageClick { get; set; }
        public RelayCommand OpenBikesPageClick { get; set; }
        public RelayCommand OpenAddBikePageClick { get; set; }
        public RelayCommand OpenAddStorePageClick { get; set; }
        private BaseWindowViewModel _selectedViewModel = new WelcomeWindowViewModel();
        public BaseWindowViewModel SelectedViewModel
        {
            get { return _selectedViewModel; }
            set 
            { 
                _selectedViewModel =  value;
                Notify("SelectedViewModel");
            }
        }

        public MainWindowViewModel()
        {
            RunStorage(); 
            OpenStoresPageClick = new RelayCommand(OpenStoresPage);
            OpenBikesPageClick = new RelayCommand(OpenBikesPage);
            OpenWelcomePageClick = new RelayCommand(OpenWelcomePage);
            OpenAddBikePageClick = new RelayCommand(OpenAddBikePage);
            OpenAddStorePageClick = new RelayCommand(OpenAddStorePage);
        }

        public void OpenStoresPage(object a)
        {
            SelectedViewModel = new StoreWindowViewModel();
        }
        public void OpenBikesPage(object a)
        {
            SelectedViewModel = new BikeWindowViewModel();
        }
        public void OpenWelcomePage(object a)
        {
            SelectedViewModel = new WelcomeWindowViewModel();
        }
        public void OpenAddBikePage(object a)
        {
            SelectedViewModel = new AddBikeWindowViewModel();
        }
        public void OpenAddStorePage(object a)
        {
            SelectedViewModel = new AddStoreWindowViewModel();
        }
        public void Notify(string a)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(a));
            }
        }
    }
}
