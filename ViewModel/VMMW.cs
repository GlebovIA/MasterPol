using MasterPol.View.CommonPages;
using System.Windows.Controls;

namespace MasterPol.ViewModel
{
    public class VMMW
    {
        private static MainWindow _mw { get; set; }
        private static MainPage _mp { get; set; }
        public VMMW(MainWindow mw)
        {
            MW = mw;
            MP = new MainPage();
            OpenPages(MP);
        }
        public static MainWindow MW
        {
            get { return _mw; }
            private set { _mw = value; }
        }
        public static MainPage MP
        {
            get { return _mp; }
            private set { _mp = value; }
        }
        public static void OpenPages(Page page)
        {
            MW.frame.Navigate(page);
        }
    }
}
