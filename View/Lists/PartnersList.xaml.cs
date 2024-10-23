using MasterPol.ViewModel;
using System.Windows.Controls;

namespace MasterPol.View.Lists
{
    /// <summary>
    /// Логика взаимодействия для PartnersList.xaml
    /// </summary>
    public partial class PartnersList : Page
    {
        public PartnersList()
        {
            InitializeComponent();
            DataContext = new VMPartnersList(this);
        }
    }
}
