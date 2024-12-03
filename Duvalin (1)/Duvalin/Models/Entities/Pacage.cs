using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duvalin.Models.Entities
{
    public class Pacage : NotifyProperty
    {
        private int _id;

        private string _FuelType = null!;

        private string _EngineVolume = null!;

        private int _EnginePower;

        private string _KPPType = null!;

        private string _DriveType = null!;

        private string _CallType = null!;

        private string _CallColor = null!;

        private string _Rudder = null!;

        private string _NamePacage = null!;

        Random Random = new Random();
        public int Id
        {
            get => _id;
            set
            {
                if (_id != value)
                {
                    _id = Random.Next(1,1000);
                    OnPropertyChanged();
                }
            }
        }

        public string FuelType
        {
            get => _FuelType;
            set
            {
                if (_FuelType != value)
                {
                    _FuelType = value;
                    OnPropertyChanged();
                }
            }
        }

        public string EngineVolume
        {
            get => _EngineVolume;
            set
            {
                if (_EngineVolume != value)
                {
                    _EngineVolume = value;
                    OnPropertyChanged();
                }
            }
        }

        public int EnginePower
        {
            get => _EnginePower;
            set
            {
                if (_EnginePower != value)
                {
                    _EnginePower = value;
                    OnPropertyChanged();
                }
            }
        }

        public string KPPType
        {
            get => _KPPType;
            set
            {
                if (_KPPType != value)
                {
                    _KPPType = value;
                    OnPropertyChanged();
                }
            }
        }

        public string DriveType
        {
            get => _DriveType;
            set
            {
                if (_DriveType != value)
                {
                    _DriveType = value;
                    OnPropertyChanged();
                }
            }
        }

        public string CallType
        {
            get => _CallType;
            set
            {
                if (_CallType != value)
                {
                    _CallType = value;
                    OnPropertyChanged();
                }
            }
        }

        public string CallColor
        {
            get => _CallColor;
            set
            {
                if (_CallColor != value)
                {
                    _CallColor = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Rudder
        {
            get => _Rudder;
            set
            {
                if (_Rudder != value)
                {
                    _Rudder = value;
                    OnPropertyChanged();
                }
            }
        }

        public string NamePacage
        {
            get => _NamePacage;
            set
            {
                if (_NamePacage != value)
                {
                    _NamePacage = value;
                    OnPropertyChanged();
                }
            }
        }

    }
}
