using AirTravel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvvm.Models.Entities
{
    public class ModelCar : NotifyProperty
    {
        private int _id;

        private string _NameModelCar = null!;

        private Generation _GenID { get; set; } = null!;

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

        public Generation GenID
        {
            get => _GenID;
            set
            {
                if (_GenID != value)
                {
                    _GenID = value;
                    OnPropertyChanged();
                }
            }
        }




    }
}
