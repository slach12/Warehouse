using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ActivityApp
{
    public class Program
    {
        public const string FILE_NAME = @"C:\Exercises \ImportFile.xlsx";//@ oznacza żeby traktować ukośnik"\" jako zwykły znak
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /*
                Program tworzy zestawienie aktywności fizycznych, każda aktywność ma typ : pływanie , bieganie , ćwiczenie.
                Klasa aktywność ma własności:
                >	Data aktywności
                >   Ilość:
                        o Pływanie -ilość basenów
                        o   Bieganie - dystans
                        o Ćwiczenie – ilość powtórzeń
                >   Wartość:
                        o Pływanie – długość basenu
                        o Ćwiczenie – waga obciążenia
                        o Bieganie – nachylenie bierźni
                >  	Czas trwania aktywności
                >	Waga po ćwiczeniach
                >	Opcjonalnie spalone kalorie.
                Program będzie potrafił:
                •	Dodać aktywność
                •	Usunąć aktywność
                •	Edytować aktywność
                •	Zrobić zestawienie aktywności po typie
                •	Zrobić zestawienie aktywności w zadanym okresie czasu
            */

            Console.WriteLine("Witam w  Activty App!");
            Console.WriteLine("Powiedz mi co chesz zrobić:");
            Console.WriteLine("1. Dodać aktywność");
            Console.WriteLine("2. Usunąć aktywność");
            Console.WriteLine("3. Sprawdzić listę aktywności");
            Console.WriteLine("Wybierz opcię 1,2 lub 3...");

            string choice = Console.ReadLine();
            int choiseOption = 0;
            Int32.TryParse(choice, out choiseOption);
        }
    }
}
