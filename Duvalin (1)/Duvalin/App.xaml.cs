using Duvalin.Models;
using Duvalin.ViewModels;
using Duvalin.Views;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Duvalin
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private DbContextFactory _context;

        public DataContext Context => _context.Create();

        public App()
        {

        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            //PresentationTraceSources.DataBindingSource.Switch.Level = SourceLevels.Information;
            var builder = new DbContextOptionsBuilder<DataContext>();
            builder.UseSqlServer(@"Server=Anastasia-ПК\SQLEXPRESS;Database=MVVM;Trusted_Connection=true;MultipleActiveResultSets=true;TrustServerCertificate=true;encrypt=false");

            this._context = new DbContextFactory(builder.Options);

            //var saveServise = new SaveDatas();
            //var selectVM = new SelectViewModel(saveServise);
            //var analysisVM = new AnalysisViewModel(saveServise);

        }
    }

}
