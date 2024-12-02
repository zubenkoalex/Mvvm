using Duvalin.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duvalin.Models;

namespace Duvalin.ViewModels
{
    class AddCarViewModel
    {
        Database db = Database.getInstance();
      
        public ObservableCollection<Car> Car { get => db.Cars.Local.ToObservableCollection(); }
  

        public Car Cars { get; set; } = new Car();
       

    }
}
