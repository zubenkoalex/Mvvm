using Mvvm.Models.Entities;
using Mvvm.Models;
using System.Collections.ObjectModel;
using Mvvm.Views;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;


namespace Mvvm.ViewModels
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
			if (new AddCarViewModel { DataContext = vm}.ShowDialog() != true) return;
			db.Cars.Add(vm.car);
			db.SaveChanges();
			OnPropertyChanged(nameof(Car));
		}
		
		public void Edit(object obj) {
			var vm = new AddCarViewModel(){car = (Car)obj};
			if (new AddCarViewModel { DataContext = vm }.ShowDialog() != true) return;
			db.Entry(vm.car).State = EntityState.Modified;
			db.SaveChanges();
			OnPropertyChanged(nameof(Car));
		}
		public void Delete(object obj) {
			db.Cars.Remove((Car)obj);
			db.SaveChanges();
			OnPropertyChanged(nameof(Car));
		}


		

	}
}
