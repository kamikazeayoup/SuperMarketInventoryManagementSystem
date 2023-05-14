using System;

namespace TestingMyInputs
{
    internal class Program
    {
        public enum Categories
        {
            Meats, Frozens , Sweets
        }
        static void Main(string[] args)
        {
           int input = int.Parse(Console.ReadLine());
           while(!Enum.IsDefined(typeof(Categories) , input))
            {
                foreach(Categories cat in Enum.GetValues(typeof(Categories)))
                {
                    Console.WriteLine(cat);
                }
                for(int i = 0; i < Enum.GetValues(typeof(Categories)).Length; i++)
                {
                    Console.WriteLine($"{i + 1} - {(Categories)i}");
                }
                Console.WriteLine("Not the same Type");
                Console.WriteLine("Try To Input Another Value");
                input = int.Parse(Console.ReadLine());
            }


        }
    }
}
