using MasterPol.ViewModel;
using System.Windows;

namespace MasterPol
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new VMMW(this);
        }
    }
}
