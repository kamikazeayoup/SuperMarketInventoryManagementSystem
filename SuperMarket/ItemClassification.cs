using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
 
    //This class for identify   
    public struct ItemClassification
    {
        public enum Categories
        {
            Sweets , Drinks , Claeaning , Frozens , Baking , Receipts
        }

        public enum Places
        {
            Roof, Drink_Fridge , Freezer 
        }
        public int Category { get; set; }
        public int Place { get; set; }

        public override string ToString() => $"Category {(Categories)Category} at {(Places)Place}";
      
    }
}
