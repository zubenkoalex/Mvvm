using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvvm.Models.Entities
{
    public class Role : NotifyProperty
    {
        private int _id;

        private string _Logins = null!;

        private string _Pass = null!;

        private string _Roles = null!;

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

        public string Logins
        {
            get => _Logins;
            set
            {
                if (_Logins != value)
                {
                    _Logins = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Roles
        {
            get => _Roles;
            set
            {
                if (_Roles != value)
                {
                    _Roles = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Pass
        {
            get => _Pass;
            set
            {
                if (_Pass != value)
                {
                    _Pass = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
