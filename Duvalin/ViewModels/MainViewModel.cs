using Duvalin.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duvalin.Views;
using Duvalin.ViewModels;

namespace Duvalin.Models
{
    public class MainViewModel : NotifyProperty
    {
        Database db = Database.getInstance();
        public ObservableCollection<Car> Cars { get => db.Cars.Local.ToObservableCollection(); }


        public MainViewModel()
        {
            AddCommand = new(Add);
            EditCommand = new(Edit);
            DeleteCommand = new(Delete);
        }

        public RelayCommand AddCommand { get; set; }
        public RelayCommand EditCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }


        void Add(object obj)
        {
            var vm = new AddCarViewModel();
            if (new AddCarWindow { DataContext = vm }.ShowDialog() != true) return;
            db.Cars.Add(vm.Cars);
            db.SaveChanges();
            OnPropertyChanged(nameof(Cars));
        }

        public void Edit(object obj)
        {
            var vm = new AddCarViewModel() { Cars = (Car)obj };
            if (new AddCarWindow { DataContext = vm }.ShowDialog() != true) return;
            db.Entry(vm.Car).State = EntityState.Modified;
            db.SaveChanges();
            OnPropertyChanged(nameof(Cars));
        }
        
        public void Delete(object obj)
        {
            db.Cars.Remove((Car)obj);
            db.SaveChanges();
            OnPropertyChanged(nameof(Cars));
        }
    }
}
