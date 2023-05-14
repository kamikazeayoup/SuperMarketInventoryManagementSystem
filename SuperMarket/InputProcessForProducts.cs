using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SuperMarket
{

    static class InputProcessForProducts
    {
        public static void Add_Product()
        {
            do
            {
                int id = 0, quantity = 0;
                string name, description;
                double price, weight;
                ItemClassification item_cla = new ItemClassification();
                //This is for Adding ID
                Func<int , bool> forid;
                forid = ProductOperations.CheckAvailability;
                id = ValidationForTypes.SetInt("Id", forid);
                //This is For Adding Name
                name = ValidationForTypes.SetString("Product Name");
                //This is for Adding Description
                description = ValidationForTypes.SetString("Description");

                //This is For The Price
                Func<double , bool> dble = (value) => value > 0;
                price = ValidationForTypes.SetDouble("Price", dble);
                //This is For The Weight
                weight = ValidationForTypes.SetDouble("Weight", dble);
                //This is For Quantity
                forid = (quan) =>  quan >= 1;
                quantity = ValidationForTypes.SetInt("Quantity", forid);

                //This is for Classifiyng Category
                ItemClassification.Categories cat = new ItemClassification.Categories();
                item_cla.Category = ValidationForTypes.SetEnum("Category" , cat );
                //This is for Classifiyng Place
                ItemClassification.Places pla = new ItemClassification.Places();
                item_cla.Place = ValidationForTypes.SetEnumPlaces("Place", pla);

                Product p1 = new Product();
                p1.SetItem(id, name, weight, item_cla, quantity, description, price);
                break;


            } while (true);
        }

        public static void Edit_Product()
        {
            Func<int, bool> ForIntegers;

            int id = 0, choose = 0;
            //this is for enter the id
            while (true)
            {
                //checking if the id is available or not
                ForIntegers = (num) => !ProductOperations.CheckAvailability(num);
                id = ValidationForTypes.SetInt("Id", ForIntegers);
                break;
            }

            //this is for choose what you want to change 
            while (true)
            {
                Func<double, bool> doubfun;
                Func<int, bool> intfun;
                WriteLine("What do you want to Edit ?\n1 - Edit The Name\n2 - Edit The Price\n3 - Edit Quantity\n4 - Edit Place");
                ForIntegers = (num) => true;
                choose = ValidationForTypes.SetInt("Choose", ForIntegers);
                switch (choose)
                {
                    case 1:
                        string new_name = ValidationForTypes.SetString("Edit Name");
                        ProductOperations.EditName(id, new_name);
                        break;
                    case 2:
                        double new_price = ValidationForTypes.SetDouble("new Price", doubfun = (num) => true);
                        ProductOperations.EditPrice(id, new_price);
                        break;
                    case 3:
                        int new_quantity = ValidationForTypes.SetInt("new Quantity", intfun = (num) => true);
                        ProductOperations.EditQuantity(id, new_quantity);
                        break;
                    case 4:
                        ////////I need to Add Feature if the user want to edit one or all of them :) 
                        ItemClassification classification = new ItemClassification();
                        ItemClassification.Places pla = new ItemClassification.Places();
                        ItemClassification.Categories cat = new ItemClassification.Categories();
                        classification.Place = ValidationForTypes.SetEnumPlaces("new Place", pla);
                        classification.Category = ValidationForTypes.SetEnum("new Category", cat);
                        ProductOperations.EditPlace(id, classification);
                        break;
                    default:
                        WriteLine("Re-Enter Choose again , Out of Boundry");
                        break;
                    
                }
                break;
            }
            }

        public static void Print_Product()
        {
            //I will Specify Here The Searching and ETC///
            ProductOperations.PrintAllItems();
        }

        public static void Remove_Product()
        {
            Func<int, bool> intrem;
            int id = 0;
            while (true)
            {
                id = ValidationForTypes.SetInt("Id Remove For", intrem = (val) => !ProductOperations.CheckAvailability(val));
                ProductOperations.RemoveElementsByID(id);
                break;
            }
        }

    }
    }
