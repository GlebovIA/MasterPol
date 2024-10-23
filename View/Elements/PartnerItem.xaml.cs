using MasterPol.Model;
using MasterPol.ViewModel;
using System.Windows.Controls;

namespace MasterPol.View.Elements
{
    /// <summary>
    /// Логика взаимодействия для PartnerItem.xaml
    /// </summary>
    public partial class PartnerItem : UserControl
    {
        public PartnerItem(PartnersModel model)
        {
            InitializeComponent();
            DataContext = new VMPartnerItem(this, model);
        }
    }
}
