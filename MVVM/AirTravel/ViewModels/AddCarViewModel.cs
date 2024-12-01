using Mvvm.Models;
using Mvvm.Models.Entities;
using System.Collections.ObjectModel;

namespace Mvvm.ViewModels
{
	class AddCarViewModel
	{
        Database db = Database.getInstance();
		public ObservableCollection<Pacage> Pacages { get => db.Pacages.Local.ToObservableCollection(); }
		public ObservableCollection<Generation> Generations { get => db.Generations.Local.ToObservableCollection(); }
		public ObservableCollection<ModelCar> ModelCars { get => db.ModelCars.Local.ToObservableCollection(); }
        public ObservableCollection<Mark> Marks { get => db.Marks.Local.ToObservableCollection(); }
        public ObservableCollection<Car> Cars { get => db.Cars.Local.ToObservableCollection(); }
        public ObservableCollection<User> Users { get => db.Users.Local.ToObservableCollection(); }

		public Car Car { get; set; } = new Car();
        public Mark Mark { get; set; } = new Mark();
        public ModelCar Modelcar { get; set; } = new ModelCar();
        public Generation Generation { get; set; } = new Generation();
        public Pacage Pacage { get; set; } = new Pacage();
       
	}
}
