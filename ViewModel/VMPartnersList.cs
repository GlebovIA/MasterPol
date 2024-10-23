using MasterPol.Contexts;
using MasterPol.View.Elements;
using MasterPol.View.Lists;
using System.Collections.Generic;

namespace MasterPol.ViewModel
{
    public class VMPartnersList
    {
        private PartnersList _ppl { get; set; }
        public VMPartnersList(PartnersList ppl)
        {
            PPL = ppl;
        }
        public PartnersList PPL
        {
            get { return _ppl; }
            set { _ppl = value; }
        }
        public List<PartnerItem> Items
        {
            get
            {
                return PartnersContext.CreateItems();
            }
        }
    }
}
