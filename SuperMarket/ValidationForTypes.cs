using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SuperMarket
{
    static class ValidationForTypes
    {
        public static string SetString(string name)

        {

            WriteLine($"Enter The {name}");
            string input = ReadLine();
            return input;
        }
        public static int SetInt(string name, Func<int, bool> Condition)
        {
            while (true)
            {
                WriteLine($"Enter The {name} of The Product");
                if (!int.TryParse(ReadLine(), out int id))
                {
                    WriteLine("This is Not A number , Try To input again");
                    continue;
                }
                if (!Condition(id))
                {
                    WriteLine("Re-Enter The Number Again , and choose different one");
                    continue;
                }
                return id;
            }
        }

        public static double SetDouble(string name, Func<double, bool> bob)
        {
            while (true)
            {
                WriteLine($"Enter {name}");
                if (!double.TryParse(ReadLine(), out double price))
                {
                    WriteLine($"Valid Value , Re-Enter The {name} Again");
                    continue;
                }
                if (!bob(price))
                {
                    WriteLine($"{name} Cannot be Less than Zero , Re-Enter The {name} Again");
                    continue;

                }
                return price;
            }
        }

        public static int SetEnum(string name, ItemClassification.Categories cat){
           while(true)
            {
                int iuput;
                do
                {
                    WriteLine("What Is The Category of Your Product ? Choose One");
                    for (int i = 0; i < Enum.GetValues(typeof(ItemClassification.Categories)).Length; i++)
                    {
                        WriteLine($"{i + 1} - {(ItemClassification.Categories)i}");
                    }
                    Func<int, bool> val;
                    iuput = SetInt("Category", val = (num) => true) - 1;

                } while (!Enum.IsDefined(typeof(ItemClassification.Categories), iuput));

                return iuput;
              
            }
    }

        public static int SetEnumPlaces(string name, ItemClassification.Places pla)
        {
            while (true)
            {
                int iuput;
                do
                {
                    WriteLine($"What Is The {name} of Your Product ? Choose One");
                    for (int i = 0; i < Enum.GetValues(typeof(ItemClassification.Places)).Length; i++)
                    {
                        WriteLine($"{i + 1} - {(ItemClassification.Places)i}");
                    }
                    Func<int, bool> val;
                    iuput = SetInt($"{name}", val = (num) => true) - 1;

                } while (!Enum.IsDefined(typeof(ItemClassification.Places), iuput));

                return iuput;

            }
        }

    }
    static class PointerFunction { 
    }
}
