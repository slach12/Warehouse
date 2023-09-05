using System;
namespace Warehouse
{
    internal class Program
    {

        public const string FILE_NAME = @"C:\Warehouse\ImportFile.xlsx";
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to warehouse app!");
            Console.WriteLine("Please let me know what you want to do:");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Remove Item");
            Console.WriteLine("3. Check Item");
            Console.WriteLine("Press 1,2 or 3...");
            
            string choice = Console.ReadLine();
            Console.WriteLine($"You have chosen option number : {choice}");

            int chosenOption = 0;
            Int32.TryParse(choice, out chosenOption );

            Console.WriteLine("Please choose another option...");

            choice = Console.ReadLine();

            
            int a = 5;
            int b = a;

            Console.WriteLine(a);
            Console.WriteLine(b);

            b = 50;
            Console.WriteLine(a);
            Console.WriteLine(b);

            Item item = new Item() { Id = 1, Name = "Apple" };
            Item item2 = item;
            Console.WriteLine(item.Name);   
            Console.WriteLine(item2.Name);

            item2.Name = "Watermelon";
            Console.WriteLine(item.Name);
            Console.WriteLine(item2.Name);

            string str = "Napis o tak naprawdę dowolnej długości";

            Console.Write("Select item category: \r\n 1. Groceery \r\n 2. Clothing \r\n 3. Elelctronics");
            Console.WriteLine("To jest backslach \\ \'");
            Console.WriteLine(@"To jest backslach z użyciem małpy \  '");

        }

    }
}