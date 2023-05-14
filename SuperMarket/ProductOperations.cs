using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    static class ProductOperations
    {
       static List<Product> LstOfProduct = new List<Product>();

        public static void Add_Item(Product product)
        {
            bool NotFound = true;
           for(int i = 0; i < LstOfProduct?.Count; i++)
            {
                if (LstOfProduct[i].Id == product.Id)
                {
                    NotFound = false;
                    Console.WriteLine("I have the Same Product , I will increase the" +
                        "Quantity.");
                    LstOfProduct[i].Quantity += product.Quantity;
                    break;
                }
            }
           if(NotFound)
            {
                Console.WriteLine("Product Added Succesfuly !");
                LstOfProduct.Add(product);
            }
        }
        public static void PrintAllItems()
        {
            if (LstOfProduct?.Count == 0)
                Console.WriteLine("There's NO prodcucts in The Inventory !");
            else
            {
                Console.WriteLine($"You Have {LstOfProduct.Count} in The Inventory");
                for (int i = 0; i < LstOfProduct?.Count; i++)
                {
                    Console.WriteLine(LstOfProduct[i]);
                }
            }
        }


        public static void RemoveElementsByID(int id)
        {
            bool IsRemoved = false;
            for (int i = 0; i < LstOfProduct?.Count; i++)
            {
                if (LstOfProduct[i].Id == id)
                {
                    LstOfProduct.RemoveAt(i);
                    IsRemoved= true;
                    break;

                }

            }
            Console.WriteLine((IsRemoved) ? "The Product Removed" : "We Couldn't Find this Project" );

        }

        public static void EditName(int id , string name) {
            bool IsEditied = false;
            for (int i = 0; i < LstOfProduct?.Count; i++)
            {
                if (LstOfProduct[i].Id == id)
                {
                    LstOfProduct[i].Name= name; 
                    IsEditied = true;
                    break;

                }

            }
            Console.WriteLine((IsEditied) ? "The Product Editied" : "We Couldn't Find this Project");



        }
        public static void EditPrice(int id, double price)
        {
            bool IsEditied = false;
            for (int i = 0; i < LstOfProduct?.Count; i++)
            {
                if (LstOfProduct[i].Id == id)
                {
                    LstOfProduct[i].Price = price;
                    IsEditied = true;
                    break;

                }

            }
            Console.WriteLine((IsEditied) ? "The Product Editied" : "We Couldn't Find this Project");



        }

        public static void EditQuantity(int id, int quantity)
        {
            bool IsEditied = false;
            for (int i = 0; i < LstOfProduct?.Count; i++)
            {
                if (LstOfProduct[i].Id == id)
                {
                    LstOfProduct[i].Quantity = quantity;
                    IsEditied = true;
                    break;

                }

            }
            Console.WriteLine((IsEditied) ? "The Product Editied" : "We Couldn't Find this Project");



        }

        public static void EditPlace(int id, ItemClassification itemclass)
        {
            bool IsEditied = false;
            for (int i = 0; i < LstOfProduct?.Count; i++)
            {
                if (LstOfProduct[i].Id == id)
                {
                    LstOfProduct[i].Classifiction = itemclass;
                    IsEditied = true;
                    break;

                }

            }
            Console.WriteLine((IsEditied) ? "The Product Editied" : "We Couldn't Find this Project");



        }

        public static bool CheckAvailability(int id)
        {
            for (int i = 0; i < LstOfProduct?.Count; i++)
                if (LstOfProduct[i].Id == id)
                    return false;

            return true;

        }









    }
}
