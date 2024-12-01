using Mvvm.Models;
using Mvvm.Models.Entities;

using System.Collections.ObjectModel;


namespace Mvvm.ViewModels
{
	public class CarUserViewModel : NotifyProperty
	{
		Database db = Database.getInstance();
		public ObservableCollection<Car> Cars { get => db.Cars.Local.ToObservableCollection(); }

	}
}
