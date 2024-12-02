using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duvalin.Models.Entities
{
    public class ModelCar : NotifyProperty
    {
        private int _id;

        private string _NameModelCar = null!;

       

        public int Id
        {
            get => _id;
            set
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged();
                }
            }
        }

        public string NameModelCar
        {
            get => _NameModelCar;
            set
            {
                if (_NameModelCar != value)
                {
                    _NameModelCar = value;
                    OnPropertyChanged();
                }
            }
        }

        
    }
}
