using System;
using static System.Console;

namespace SuperMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();

            p1.SetItem(1, "Sugar", 1000, new ItemClassification() { Category = (int)ItemClassification.Categories.Receipts, Place = (int)ItemClassification.Places.Roof },
                22, "Good Product", 22);
            do
            {
                int choosen = 0;
                WriteLine("Hello And Welcome in The Inventory of the supermarket, What the operation" +
                    " want to make today ? ");
                WriteLine("1 - Add New Product\n2 - Edit Product\n3 - See All Products\n4 - Remove Product\n");
                while(!int.TryParse(ReadLine(), out choosen))
                {
                    WriteLine("Please write a numbers");
                }
                switch (choosen)
                {
                    case 1:
                        InputProcessForProducts.Add_Product();
                        break;
                        case 2:
                        InputProcessForProducts.Edit_Product();
                        break;
                        case 3:
                        InputProcessForProducts.Print_Product();
                        break;
                        case 4:
                        InputProcessForProducts.Remove_Product();
                        break;
                    default:
                        WriteLine($"{choosen} is out of Context , Please Choose Another Value ");
                        break;
                }
            } while (true);
        }
    }
}
