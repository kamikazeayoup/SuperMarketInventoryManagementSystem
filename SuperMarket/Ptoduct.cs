using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    public class Product : IItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Quantity { get; set; }
        public ItemClassification Classifiction { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public void SetItem(int id, string name, double weight, ItemClassification classification,
            int quantity ,string description, double price)
        {
            Id = id;
            Name = name;
            Weight = weight;
            Classifiction = classification;
            Quantity = quantity;
            Description = description;
            Price = price;
            ProductOperations.Add_Item(this);
        }
        public override string ToString() => $"Product Id : {Id} \nName : {Name} \nWeight : {Weight} \nPrice : {Price:C} \n" +
            $"Description : {Description} \n" +
            $"{Classifiction}\n" +
            $"Quantity : {Quantity}\n" +
            $"***************************************************";
    }
}
