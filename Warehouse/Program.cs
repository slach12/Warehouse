using System;
using static Warehouse.Helpers;

namespace Warehouse
{
    internal class Program
    {

        public const string FILE_NAME = @"C:\Warehouse\ImportFile.xlsx";
        static void Main(string[] args)
        {
            /*  Console.WriteLine("Welcome to warehouse app!");
              Console.WriteLine("Please let me know what you want to do:");
              Console.WriteLine("1. Add Item");
              Console.WriteLine("2. Remove Item");
              Console.WriteLine("3. Check Item");
              Console.WriteLine("Press 1,2 or 3...");

              string category = Console.ReadLine();
              ItemType chosenCategory;

              Enum.TryParse(category, out chosenCategory);
  */

            int a = 10;
/*
            while( a < 10 )
            {
                Console.WriteLine("Zmienna a ma wartość : "+a);
                a++;
            }*/
            /*do {
                Console.WriteLine("Zmienna a ma wartość : " + a);
                a++;
            } while (a < 10);
            Console.WriteLine("End");*/

            for (int i = 0; i < a; i++) { 
                Console.WriteLine($"Liczba i ma wartość {i} ");
            }
        }

    }
}