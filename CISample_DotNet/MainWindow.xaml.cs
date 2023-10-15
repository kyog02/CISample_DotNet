using CISample_DotNet.ViewModel;
using System.Windows;

namespace CISample_DotNet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CalcViewModel vm = new CalcViewModel();
            DataContext = vm;
        }
    }
}
