using Mvvm.Models;
using Mvvm.Views;
using System.Windows;
using System.Linq;
using System.ComponentModel;

namespace Mvvm.ViewModels
{
    public class LoginViewModel : NotifyProperty
	{
		MvvmContext db = new();
		
		private string login;
		public string Login
		{
			get => login;
			set
			{
				login = value;
				OnPropertyChanged();
			}
		}

		private string password;
		public string Password
		{
			get => password;
			set
			{
				password = value;
				OnPropertyChanged();
			}
		}

		public RelayCommand LoginCommand { get; set; }

		public LoginViewModel()
		{
			LoginCommand = new RelayCommand(ExecuteLogin);
		}

		private void ExecuteLogin(object obj)
		{
			var user = db.Logins.FirstOrDefault(u => u.Logins == Login && u.Pass == Password);
			
			if (user == null)
			{
				MessageBox.Show("Неверный логин или пароль!");
				return;
			}

			Window window;
			if (user.Roles == "admin")
			{
				window = new MainWindow1 { DataContext = new MainViewModel() };
			}
			else
			{
				window = new CarUserWindow { DataContext = new CarUserViewModel() };
			}

			window.Show();
			Application.Current.Windows[0].Close();
		}
	}
}
