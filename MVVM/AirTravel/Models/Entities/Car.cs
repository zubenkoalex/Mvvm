using Mvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvvm.Models.Entities
{
    public class Car : NotifyProperty
    {
        private int _id;
        private Mark  _MarkID { get; set; } = null!;

        private int _Mileage;

        private int _Price;

        private DateOnly? _ReleaseYear;
        private Pacage _PacID { get; set; } = null!;

        //picture

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

        public Mark MarkID
        {
            get => _MarkID;
            set
            {
                if (_MarkID != value)
                {
                    _MarkID = value;
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
        
        public DateOnly? ReleaseYear
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

        public Pacage PacID
        {
            get => _PacID;
            set
            {
                if (_PacID != value)
                {
                    _PacID = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
