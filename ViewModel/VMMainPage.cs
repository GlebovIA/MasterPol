using MasterPol.View.CommonPages;
using MasterPol.View.Lists;
using System.Windows.Controls;

namespace MasterPol.ViewModel
{
    public class VMMainPage
    {
        private static MainPage _mp { get; set; }
        public VMMainPage(MainPage mp)
        {
            MP = mp;
            OpenList(new PartnersList());
        }
        public static MainPage MP
        {
            get { return _mp; }
            private set { _mp = value; }
        }
        public static void OpenList(Page list)
        {
            MP.listFrame.Navigate(list);
        }
    }
}
