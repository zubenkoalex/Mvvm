using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duvalin.Models.Entities
{
    public class Mark : NotifyProperty
    {
        private int _id;

        private string _NameMark = null!;

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

        public string NameMark
        {
            get => _NameMark;
            set
            {
                if (_NameMark != value)
                {
                    _NameMark = value;
                    OnPropertyChanged();
                }
            }
        }

        
        
    }
}
