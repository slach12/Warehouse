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

            /* Console.WriteLine("Witam w  Activty App!");
             Console.WriteLine("Powiedz mi co chesz zrobić:");
             Console.WriteLine("1. Dodać aktywność");
             Console.WriteLine("2. Usunąć aktywność");
             Console.WriteLine("3. Sprawdzić listę aktywności");
             Console.WriteLine("Wybierz opcię 1,2 lub 3...");

             string choice = Console.ReadLine();
             int choiseOption = 0;
             Int32.TryParse(choice, out choiseOption);*/

            //Użytkownik zostanie przywitany
            ////a. Stworzenie nowego ćwiczenia
            ////b. Usunięcie ćwiczenia
            ////c. Wyświetlenie listy ćwiczeń
            ////d. Zwrócenie listy ćwiczeń o zadanym filtrze (nazwa kategorii)
            /////a1. Najpierw dostanę wyboru kategorię ćwiczenia
            /////a2. Zostanę poproszony o wprowadzenie wszystkich szczegułów
            /////b1. Zostanę poproszony o id albo nazwę produktu
            /////b2. Usunę ten produkt z listy produktów
            /////
            
            Console.WriteLine("Witam w  Activty App!");
            Console.WriteLine("Powiedz mi co chesz zrobić:");

            MenuActionService actionService = new MenuActionService();
            actionService = Initialize(actionService);

            var mainMenu = actionService.GetMenuActionsByMenuName("Menu");
            for(int i = 0; i < mainMenu.Count; i++)
            {
                Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
            }
            var operation = Console.ReadKey();
            switch (operation.KeyChar)
            {
                case '1':
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;

                default: 
                    Console.WriteLine("Polecenie, które wybrałeś nie istnieje.");
                    break;
            }

        }

        private static MenuActionService Initialize(MenuActionService actionService)
        {
            actionService.AddNewAction(1, "Dodaj aktywność", "Main");
            actionService.AddNewAction(2, "Usuń aktwyność", "Main");
            actionService.AddNewAction(3, "Pokaż detale aktywności", "Main");
            actionService.AddNewAction(4, "Lista aktywności", "Main");
            return actionService;
        }
    }
}
