using System;

namespace MasterPol.Model
{
    public class PartnerProductsModel
    {
        private int _id { get; set; }
        private int _product { get; set; }
        private int _partner { get; set; }
        private int _count { get; set; }
        private DateTime _dateOfSell { get; set; }
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int product
        {
            get { return _product; }
            set { _product = value; }
        }
        public int partner
        {
            get { return _partner; }
            set { _partner = value; }
        }
        public int count
        {
            get { return _count; }
            set { _count = value; }
        }
        public DateTime dateOfSell
        {
            get { return _dateOfSell; }
            set { _dateOfSell = value; }
        }
    }
}
