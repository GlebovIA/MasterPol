using MasterPol.ViewModel;
using System.Windows.Controls;

namespace MasterPol.View.CommonPages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            DataContext = new VMMainPage(this);
        }
    }
}
