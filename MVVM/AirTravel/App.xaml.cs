using Mvvm.ViewModels;
using Mvvm.Views;
using Mvvm.Models;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AirTravel
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IServiceProvider _serviceProvider;

        public App()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            _serviceProvider = services.BuildServiceProvider();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var loginWindow = new LoginWindow
            {
                DataContext = new LoginViewModel()
            };
            loginWindow.Show();


        }
        
        private void ConfigureServices(IServiceCollection services)
            {
                // Регистрация DbContext
                services.AddDbContext<MvvmContext>(options =>
                {
                    options.UseSqlServer(@"Server=zubenkoag;Database=MVVM;User=user1;Password=sa;Trusted_Connection=true;MultipleActiveResultSets=true;TrustServerCertificate=true;encrypt=false");
                });


            // Регистрация ViewModel
            services.AddTransient<MainViewModel>();
            services.AddTransient<AddCarViewModel>();
            services.AddTransient<UserViewModel>();
            services.AddTransient<LoginViewModel>();
            services.AddTransient<CarUserViewModel>();


            // Регистрация окон
            services.AddTransient<MainWindow1>();
            services.AddTransient<AddCarWindow>();
            services.AddTransient<CarUserWindow>();
            services.AddTransient<LoginWindow>();


        }
        
    }
}


