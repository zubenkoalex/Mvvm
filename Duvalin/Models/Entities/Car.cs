using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duvalin.Models.Entities
{
    public class Car : NotifyProperty
    {
        private int _id;
        private Mark _Mark { get; set; } = null!;

        private ModelCar _ModelCar { get; set; } = null!;

        private Generation _Generation { get; set; } = null!;

        private Pacage _Pacage { get; set; } = null!;

        private int _Mileage;

        private int _Price;

        private int _ReleaseYear;

        private string _Picture = null!;

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

        public Mark Mark
        {
            get => _Mark;
            set
            {
                if (_Mark != value)
                {
                    _Mark = value;
                    OnPropertyChanged();
                }
            }
        }

        public ModelCar ModelCar
        {
            get => _ModelCar;
            set
            {
                if (_ModelCar != value)
                {
                    _ModelCar = value;
                    OnPropertyChanged();
                }
            }
        }

        public Generation Generation
        {
            get => _Generation;
            set
            {
                if (_Generation != value)
                {
                    _Generation = value;
                    OnPropertyChanged();
                }
            }
        }

        public int Mileage
        {
            get => _Mileage;
            set
            {
                if (_Mileage != value)
                {
                    _Mileage = value;
                    OnPropertyChanged();
                }
            }
        }

        public int Price
        {
            get => _Price;
            set
            {
                if (_Price != value)
                {
                    _Price = value;
                    OnPropertyChanged();
                }
            }
        }

        public int ReleaseYear
        {
            get => _ReleaseYear;
            set
            {
                if (_ReleaseYear != value)
                {
                    _ReleaseYear = value;
                    OnPropertyChanged();
                }
            }
        }

        public Pacage Pacage
        {
            get => _Pacage;
            set
            {
                if (_Pacage != value)
                {
                    _Pacage = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Picture
        {
            get => _Picture;
            set
            {
                if (_Picture != value)
                {
                    _Picture = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
