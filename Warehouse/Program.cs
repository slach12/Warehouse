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

            //  int a = 10;
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

            /*     for (int i = 0; i < a; i++) { 
                     Console.WriteLine($"Liczba i ma wartość {i} ");
                 }*/

            /*    for(int a=0; a<10; a++)
                {
                    if (a == 5)
                    {
                        //break;
                        //continue;
                        goto Found;
                    }
                    else
                    {
                        Console.WriteLine("Liczba a ma wartość :"+a);
                    }
                }

            Found:
                Console.WriteLine("Znaleziono liczbę 5");*/

            int[] cyfry1 = new int[] { 1,2,3,4,5,6,7,8,9,0};
            int[] cyfry2 = new int[10];
            
            for(int i = 0; i < 10; i++)
            {
                cyfry2[i] = i;
            }

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Aktualny element tablicy to : " + cyfry2[i]);
            }

            int wielkoscTablicy = cyfry2.Length;
            int ostatniaCyfra = cyfry2[wielkoscTablicy-1];
            int idexOfFive = Array.IndexOf(cyfry2, 5);

            int[] unsortedCyfry = new int[] { 1, 2, 6, 7, 0, 9, 4, 3, 5 };
            Console.WriteLine("Wartości przed sortowaniem:");
            for (int i = 0;i < unsortedCyfry.Length;i++)
            {
                Console.Write(unsortedCyfry[ i]+" ");
            }
            Array.Sort(unsortedCyfry);
            Console.WriteLine();
            Console.WriteLine("Wartości po sortowaniu:");
            for (int i = 0; i < unsortedCyfry.Length; i++)
            {
                Console.Write(unsortedCyfry[i] + " ");
            }

            int[,] tabDwuWymiarowa = new int[3,4] { { 1,3,5,7},{ 2,4,6,8},{ 1,2,3,4} };
            Console.WriteLine();
            Console.WriteLine("Tablica dwuwymiarowa");
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j< 4; j++)
                {
                    Console.WriteLine($"Liczba z wiersza {i} i kolumny {j} ma wartość : {tabDwuWymiarowa[i,j]} ");
                }
            }
            Array.Clear(unsortedCyfry, 2, 4);
        }
         
    }
}