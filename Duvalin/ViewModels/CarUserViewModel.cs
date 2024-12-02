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

    }
}
