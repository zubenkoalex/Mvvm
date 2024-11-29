using Mvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvvm.Models.Entities
{
    public class Generation : NotifyProperty
    {
        private int _id;

        private string _NameGeneration = null!;

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

        public string NameGeneration
        {
            get => _NameGeneration;
            set
            {
                if (_NameGeneration != value)
                {
                    _NameGeneration = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
