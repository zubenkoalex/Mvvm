using Duvalin.Models.Entities;
using Duvalin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duvalin.ViewModels
{
    public class CarUserViewModel : NotifyProperty
    {
        Database db = Database.getInstance();
        public ObservableCollection<Car> Cars { get => db.Cars.Local.ToObservableCollection(); }

        public ObservableCollection<Pacage> Pacages { get => db.Pacages.Local.ToObservableCollection(); }

        public ObservableCollection<Mark> Marks { get => db.Marks.Local.ToObservableCollection(); }

        public ObservableCollection<ModelCar> ModelCars { get => db.ModelCars.Local.ToObservableCollection(); }

        public ObservableCollection<Generation> Generations { get => db.Generations.Local.ToObservableCollection(); }

        public ObservableCollection<User> Users { get => db.Users.Local.ToObservableCollection(); }

        





    }
}
