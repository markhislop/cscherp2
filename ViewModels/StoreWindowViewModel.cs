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
    class StoreWindowViewModel : BaseWindowViewModel
    {
        public Stores SelectedStore { get; set; }
        public RelayCommand RemoveStoreClick { get; set; }
        public RelayCommand EditStoreClick { get; set; }
        public BikeRentalDb db { get; set; } = new BikeRentalDb();
        public StoreWindowViewModel()
        {
            db.Stores.Load();
            EditStoreClick = new RelayCommand(EditStore);
            RemoveStoreClick = new RelayCommand(RemoveStore);
        }

        public void EditStore(object a)
        {
            if (SelectedStore != null)
            {
                Stores dbStore = db.Stores.Local.First(store => store.Id == SelectedStore.Id);
                PropertyCopy.Copy(dbStore, SelectedStore);
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Er is geen bike gekozen!!!");
            }
        }
        public void RemoveStore(object a)
        {
            if (SelectedStore != null)
            {
                db.Stores.Local.Remove(SelectedStore);
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Er is geen Store gekozen!!!");
            }

        }
    }
}
