using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterPol.Model
{
    public class ProductTypes
    {
        private int _id { get; set; }
        private string _name { get; set; }
        private float _coefficient { get; set; }
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
        public float coefficient
        {
            get { return _coefficient; }
            set { _coefficient = value; }
        }
    }
}
