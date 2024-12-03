using Duvalin.Models;
using Duvalin.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Duvalin.ViewModels
{
    public class LoginViewModel
    {
        public Database db = new Database();
        public string Login { get; set; }
        public string Password { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(LogIn);
        }
        public RelayCommand LoginCommand { get; set; }
        void LogIn(object o)
        {
            var u = db.Users.Where(x => x.Logins == Login && x.Pass == Password).FirstOrDefault();
            if (u != null)
            {
                if (u.Roles == "Admin")
                {
                    var w = new MainWindow();
                    w.Show();
                    Application.Current.MainWindow.Close();
                    Application.Current.MainWindow = w;
                }
                else
                {
                    var w = new CarUserWindow() { DataContext = new CarUserViewModel() };
                    w.Show();
                    Application.Current.MainWindow.Close();
                    Application.Current.MainWindow = w;
                }
            }
            else
                MessageBox.Show("Incorrect login/password");
        }
    }
}
