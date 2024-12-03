using Duvalin.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duvalin.Views;
using Duvalin.Models;
using System.Windows.Controls;

namespace Duvalin.ViewModels
{
    public class CarDTO
    {
        public int Id { get; set; }
        public int Mark { get; set; }
        public int Model { get; set; }
        public int Generation { get; set; }
    }
    public class MainViewModel : NotifyProperty
    {
        //Database db = Database.getInstance();
        public ObservableCollection<int> CarsId { get; set; }

        //public ObservableCollection<Pacage> Pacages { get => db.Pacages.Local.ToObservableCollection(); }

        //DataContext db = new DataContext();

        public ObservableCollection<CarDTO> Cars { get; set; }
        private readonly DataContext _context; 
        public MainViewModel(DataContext context)
        {
            _context = context; 
            Cars = new(_context.Cars.Select(m => 
            new CarDTO()
            {
                Id = m.Id,
                Mark = m.Mark,
                Model = m.ModelCar,
                Generation = m.Generation,
            }));
            

            //AddCommand = new(Add);
            //EditCommand = new(Edit);
            //DeleteCommand = new(Delete);
        }

        public RelayCommand AddCommand { get; set; }
        public RelayCommand EditCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }


        //void Add(object obj)
        //{
        //    var vm = new AddCarViewModel();
        //    if (new AddCarWindow { DataContext = vm }.ShowDialog() != true) return;
        //    db.Cars.Add(vm.Car);
        //    db.SaveChanges();
        //    OnPropertyChanged(nameof(Cars));
        //}

        //public void Edit(object obj)
        //{
        //    var vm = new AddCarViewModel() { Car = (Car)obj };
        //    if (new AddCarWindow { DataContext = vm }.ShowDialog() != true) return;
        //    db.Entry(vm.Car).State = EntityState.Modified;
        //    db.SaveChanges();
        //    OnPropertyChanged(nameof(Cars));
        //}

        //public void Delete(object obj)
        //{
        //    db.Cars.Remove((Car)obj);
        //    db.SaveChanges();
        //    OnPropertyChanged(nameof(Cars));
        //}
    }
}
