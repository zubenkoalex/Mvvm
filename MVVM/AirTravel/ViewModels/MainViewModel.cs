
using Mvvm.Models;
using System.Collections.ObjectModel;
using Mvvm.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows;

using Mvvm.Models.Entities;

namespace Mvvm.ViewModels
{
    public class MainViewModel : NotifyProperty, IDisposable
    {
        private readonly MvvmContext db = new MvvmContext();
        public ObservableCollection<CarEntity> CarEntities { get => db.CarEntities.Local.ToObservableCollection(); }


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
            try
            {
                var vm = new AddCarViewModel();
                var window = new AddCarWindow { DataContext = vm };
                if (window.ShowDialog() != true) return;
                db.CarEntities.Add(vm.Car);
                db.SaveChanges();
                OnPropertyChanged(nameof(CarEntities));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении: {ex.Message}");
            }
        }

        public void Edit(object obj)
        {
            if (obj == null) return;

            try
            {
                var vm = new AddCarViewModel() { Car = (CarEntity)obj };
                var window = new AddCarWindow { DataContext = vm };
                if (window.ShowDialog() != true) return;
                db.Entry(vm.Car).State = EntityState.Modified;
                db.SaveChanges();
                OnPropertyChanged(nameof(CarEntities));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при редактировании: {ex.Message}");
            }
        }
        public void Delete(object obj)
        {
            if (obj == null) return;

            try
            {
                db.CarEntities.Remove((CarEntity)obj);
                db.SaveChanges();
                OnPropertyChanged(nameof(CarEntities));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении: {ex.Message}");
            }
        }

        public void Dispose()
        {
            db?.Dispose();
        }




    }
}
