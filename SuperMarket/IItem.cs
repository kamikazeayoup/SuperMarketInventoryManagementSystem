using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    public interface IItem
    {
        public int Id { get; set;  }
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Quantity { get; set; }
        public ItemClassification Classifiction { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public void SetItem(int id , string name , double weight , ItemClassification classification ,
            string description , double price)
        {

        }
    }
}
