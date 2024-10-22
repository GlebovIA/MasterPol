namespace MasterPol.Model
{
    public class PartnersModel
    {
        private int _id { get; set; }
        private int _type { get; set; }
        private string _name { get; set; }
        private string _juridicalAddress { get; set; }
        private long _inn { get; set; }
        private string _directorFio { get; set; }
        private long _phone { get; set; }
        private string _email { get; set; }
        private int _rating { get; set; }
        private string _historyOfImplementation { get; set; }
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int type
        {
            get { return _type; }
            set { _type = value; }
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string juridicalAddress
        {
            get { return _juridicalAddress; }
            set { _juridicalAddress = value; }
        }
        public long inn
        {
            get { return _inn; }
            set { _inn = value; }
        }
        public string directorFio
        {
            get { return _directorFio; }
            set { _directorFio = value; }
        }
        public long phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        public int rating
        {
            get { return _rating; }
            set { _rating = value; }
        }
        public string historyOfImplementation
        {
            get { return _historyOfImplementation; }
            set { _historyOfImplementation = value; }
        }
    }
}
