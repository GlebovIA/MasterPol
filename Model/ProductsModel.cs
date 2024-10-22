namespace MasterPol.Model
{
    public class ProductsModel
    {
        private int _id { get; set; }
        private int _article { get; set; }
        private int _type { get; set; }
        private string _name { get; set; }
        private string _description { get; set; }
        private int _minCost { get; set; }
        private int _massNetto { get; set; }
        private int _massBrutto { get; set; }
        private int _productionTime { get; set; }
        private int _realCost { get; set; }
        private int _workshopNumber { get; set; }
        private int _countOfWorkers { get; set; }
        private string _materials { get; set; }
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int article
        {
            get { return _article; }
            set { _article = value; }
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
        public string description
        {
            get { return _description; }
            set { _description = value; }
        }
        public int minCost
        {
            get { return _minCost; }
            set { _minCost = value; }
        }
        public int massNetto
        {
            get { return _massNetto; }
            set { _massNetto = value; }
        }
        public int massBrutto
        {
            get { return _massBrutto; }
            set { _massBrutto = value; }
        }
        public int productionTime
        {
            get { return _productionTime; }
            set { _productionTime = value; }
        }
        public int realCost
        {
            get { return _realCost; }
            set { _realCost = value; }
        }
        public int workshopNumber
        {
            get { return _workshopNumber; }
            set { _workshopNumber = value; }
        }
        public int countOfWorkers
        {
            get { return _countOfWorkers; }
            set { _countOfWorkers = value; }
        }
        public string materials
        {
            get { return _materials; }
            set { _materials = value; }
        }
    }
}
