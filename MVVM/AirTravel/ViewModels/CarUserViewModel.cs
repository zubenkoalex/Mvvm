using Mvvm.Models;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Mvvm.Views;
using System.Collections.ObjectModel;
using Mvvm.Models.Entities;


namespace Mvvm.ViewModels
{
    public class CarUserViewModel : NotifyProperty
    {
        private ObservableCollection<CarEntity> _car;
        private CarEntity? _selectedCar;

        public ObservableCollection<CarEntity> Car
        {
            get => _car;
            set
            {
                _car = value;
                OnPropertyChanged();
            }
        }

        public CarEntity? SelectedCar
        {
            get => _selectedCar;
            set
            {
                _selectedCar = value;
                OnPropertyChanged();
            }
        }

           

        public CarUserViewModel()
        {
            _car = new ObservableCollection<CarEntity>();
            LoadCar();
        }

        private void LoadCar()
        {
            try
            {
                using (var context = new MvvmContext())
                {
                    var car = context.CarEntities.ToList();
                    Car = new ObservableCollection<CarEntity>(car);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка");
            }
        }

       
        }
    }
    
        
