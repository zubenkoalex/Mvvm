using Mvvm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Mvvm.Views
{ 
    public partial class AddCarWindow : Window
    {
        private readonly AddCarViewModel _viewModel;
        public AddCarWindow()
        {
            InitializeComponent();
        }

        public AddCarWindow(AddCarViewModel viewModel) : this()
        {
            _viewModel = viewModel;
            DataContext = _viewModel;
        }
    }
}

    
