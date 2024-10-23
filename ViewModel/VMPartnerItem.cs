using MasterPol.Contexts;
using MasterPol.Model;
using MasterPol.View.Elements;

namespace MasterPol.ViewModel
{
    public class VMPartnerItem
    {
        private PartnerItem _item { get; set; }
        private PartnersModel _model { get; set; }
        public VMPartnerItem(PartnerItem item, PartnersModel model)
        {
            Item = item;
            Model = model;
        }
        public PartnerItem Item
        {
            get { return _item; }
            set { _item = value; }
        }
        public PartnersModel Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public string GetTitle
        {
            get { return PartnersContext.GetPartnerType(Model.type) + " | " + Model.name; }
        }
        public string GetDiscount
        {
            get { return PartnersContext.CountDiscount(Model.id); }
        }
    }
}
