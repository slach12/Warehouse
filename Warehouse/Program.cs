using System;
using static Warehouse.Helpers;

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

            string category = Console.ReadLine();
            ItemType chosenCategory;
            Enum.TryParse(category, out chosenCategory);


            a = 5;
            b = 10;
            int wynik;
            wynik = a + b;
            Console.WriteLine("a + b");
            Console.WriteLine(wynik);
            wynik = a - b;
            Console.WriteLine("a - b");
            Console.WriteLine(wynik);
            wynik = a * b;
            Console.WriteLine("a * b");
            Console.WriteLine(wynik);
            wynik = a / b;
            Console.WriteLine("a / b");
            Console.WriteLine(wynik);
            wynik = a % b;
            Console.WriteLine("a % b");
            Console.WriteLine(wynik);
            b = 8;
            wynik = a % b;
            Console.WriteLine("a % b");
            Console.WriteLine(wynik);
            Console.WriteLine(a);
            Console.WriteLine("a++");
            a++;
            Console.WriteLine(a);

            string ala = "Ala ma";
            string kota = "kota";

            string alaMaKota = ala + kota;
            Console.WriteLine(alaMaKota);

            if (chosenOption == 1 && chosenCategory == ItemType.Clothing) {
                Console.WriteLine(alaMaKota);
                Console.WriteLine(alaMaKota);
                Console.WriteLine(alaMaKota);
            }


            /*            Item item4 = new Item() { Id = 4, Name = "Strawberry" };

                        item4.CategoryId = chosenCategory switch { 
                            ItemType.Grocery => 1,
                            ItemType.Clothing => 2,
                            ItemType.Electronics => 3,
                            _ => -1
                        };


                        if(chosenOption == 1 && chosenCategory == ItemType.Grocery)
                        {
                            //
                        }

                        ItemService itemService = new ItemService();

                        switch (chosenOption)
                        {
                            case 1:
                                itemService.AddItem();
                                break;
                            case 2:
                                itemService.RemoveItem();
                                break;
                            default: 
                                //Wyrzucić wyjątek i poinformować użytkownika o błędnym wyborze
                                break;
                        }
            */
            /*           if (chosenOption == 1)
                       {
                           Item item3 = new Item() { Id = 3, Name = "Strawbery" };
                           item3.CategoryId = chosenCategory == ItemTypes.Grocery ? 1 : 2;

                           if (chosenCategory == ItemTypes.Grocery)
                           {
                               item3.CategoryId = 1;
                           }
                           else
                           {
                               item3.CategoryId = 2;
                           }


                       }*/

            /*            if (chosenOption == 1)
                        {
                            Item aItem = new Item() { Id = 2, Name = "Strawberry" };
                        }
                        else if (chosenOption == 2) 
                        {
                            //Coś dla if elsa
                        }
                        else
                        {
                            //Coś dla elsa
                        }
            */


        }

    }
}