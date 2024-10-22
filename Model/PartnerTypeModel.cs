namespace MasterPol.Model
{
    public class PartnerTypeModel
    {
        private int _id { get; set; }
        private string _name { get; set; }
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
