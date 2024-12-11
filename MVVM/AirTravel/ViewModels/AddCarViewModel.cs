using Mvvm.Models;
using System.Collections.ObjectModel;
using Mvvm.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore.Design;
using Mvvm.Models.Entities;

namespace Mvvm.ViewModels
{
    public class AddCarViewModel : NotifyProperty, IDisposable
    {
        private readonly MvvmContext db = new MvvmContext();

        public AddCarViewModel()
        {
            // Инициализация пустых коллекций
            _pacages = new ObservableCollection<PacageEntity>();
            _generations = new ObservableCollection<GenerationEntity>();
            _modelsCar = new ObservableCollection<ModelEntity>();
            _marks = new ObservableCollection<MarkEntity>();

            SaveCommand = new RelayCommand(Save, CanSave);
            CancelCommand = new RelayCommand(Cancel);
            
            _ = LoadDataAsync();
        }

        // Команды
        public RelayCommand SaveCommand { get; }
        public RelayCommand CancelCommand { get; }

        // Коллекции с правильной реализацией
        private ObservableCollection<PacageEntity> _pacages;
        public ObservableCollection<PacageEntity> Pacages
        {
            get => _pacages;
            private set
            {
                _pacages = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<GenerationEntity> _generations;
        public ObservableCollection<GenerationEntity> Generations
        {
            get => _generations;
            private set
            {
                _generations = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<ModelEntity> _modelsCar;
        public ObservableCollection<ModelEntity> ModelsCar
        {
            get => _modelsCar;
            private set
            {
                _modelsCar = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<MarkEntity> _marks;
        public ObservableCollection<MarkEntity> Marks
        {
            get => _marks;
            private set
            {
                _marks = value;
                OnPropertyChanged();
            }
        }

        // Выбранные сущности
        private CarEntity _car = new();
        public CarEntity Car 
        { 
            get => _car;
            set
            {
                _car = value;
                ValidateCarData();
                OnPropertyChanged();
            }
        }

        // Флаг валидности
        private bool _isValid;
        public bool IsValid
        {
            get => _isValid;
            private set
            {
                _isValid = value;
                OnPropertyChanged();
                SaveCommand?.RaiseCanExecuteChanged();
            }
        }

        // Асинхронная загрузка данных
        private async Task LoadDataAsync()
        {
            try
            {
                await Task.WhenAll(
                    db.PacageEntities.LoadAsync(),
                    db.GenerationEntities.LoadAsync(),
                    db.ModelEntities.LoadAsync(),
                    db.MarkEntities.LoadAsync()
                );

                Pacages = db.PacageEntities.Local.ToObservableCollection();
                Generations = db.GenerationEntities.Local.ToObservableCollection();
                ModelsCar = db.ModelEntities.Local.ToObservableCollection();
                Marks = db.MarkEntities.Local.ToObservableCollection();

                ValidateCarData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}");
            }
        }

        private void ValidateCarData()
        {
            IsValid = Car != null &&
                     Car.MarkId != null &&
                     Car.PacageId != null;
        }

        private bool CanSave(object parameter)
        {
            return IsValid;
        }

        private async void Save(object parameter)
        {
            try
            {
                if (!IsValid)
                {
                    MessageBox.Show("Пожалуйста, заполните все обязательные поля корректно.");
                    return;
                }

                DialogResult = true;
                Close?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}");
            }
        }

        private void Cancel(object parameter)
        {
            DialogResult = false;
            Close?.Invoke();
        }

        public void Dispose()
        {
            ((IDisposable)db).Dispose();
        }

        // Свойства диалога
        public bool? DialogResult { get; set; }
        public Action? Close { get; set; }
    }
}
