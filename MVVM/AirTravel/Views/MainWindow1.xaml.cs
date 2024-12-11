using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Mvvm.ViewModels;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Mvvm.Models;

namespace Mvvm.Views
{
    public partial class MainWindow1 : Window
    {
        private readonly MainViewModel _viewModel;
        public MainWindow1()
        {
            InitializeComponent();
        }

        public MainWindow1(MainViewModel viewModel) : this()
        {
            _viewModel = viewModel;
            DataContext = _viewModel;
        }
    }
}

