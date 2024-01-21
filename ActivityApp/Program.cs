﻿using static System.Runtime.InteropServices.JavaScript.JSType;

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
            ////####################################a. Stworzenie nowej aktywności
            ////####################################b. Usunięcie aktywności
            ////####################################c. Wyświetlenie listy aktywności
            ////d. Zwrócenie listy aktywności o zadanym filtrze (nazwa kategorii)
            /////###################################a1. Najpierw dostanę wyboru kategorię aktywności
            /////###################################a2. Zostanę poproszony o wprowadzenie wszystkich szczegułów
            /////###################################b1. Zostanę poproszony o id albo nazwę aktywności
            /////###################################b2. Usunę tę aktywność z listy aktywności
            /////###################################c1. Zostanę poproszony o wprowadzenie id aktywności
            /////###################################c2. Wyświetlę wszystkie informacje związane z tą aktywnością
            /////d1. Zostanę poproszony o wprowadzenie nazwy albo id kategorii
            /////d2. Wyświetlę listę aktywności

            Console.WriteLine("Witam w  Activty App!");
            MenuActionService actionService = new MenuActionService();
            actionService = Initialize(actionService);
            ItemService itemService = new ItemService();
            while (true) 
            {
                Console.WriteLine("Powiedz mi co chesz zrobić:");
                var mainMenu = actionService.GetMenuActionsByMenuName("Main");
                for (int i = 0; i < mainMenu.Count; i++)
                {
                    Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
                }
                var operation = Console.ReadKey();
                
                switch (operation.KeyChar)
                {
                    case '1':
                        var keyInfo = itemService.AddNewItemView(actionService);
                        var id = itemService.AddNewItem(keyInfo.KeyChar);
                        break;
                    case '2':
                        var removeId = itemService.RemoveItemView();
                        itemService.RemoveItem(removeId);
                        break;
                    case '3':
                        var detailId = itemService.ItemDetailSelectionView();
                        itemService.ItemDetailView(detailId);
                        break;
                    case '4':
                        break;

                    default:
                        Console.WriteLine("Polecenie, które wybrałeś nie istnieje.");
                        break;
                }

            }


        }

        private static MenuActionService Initialize(MenuActionService actionService)
        {
            actionService.AddNewAction(1, "Dodaj aktywność", "Main");
            actionService.AddNewAction(2, "Usuń aktwyność", "Main");
            actionService.AddNewAction(3, "Pokaż detale aktywności", "Main");
            actionService.AddNewAction(4, "Lista aktywności", "Main");

            actionService.AddNewAction(1, "Pływanie", "AddNewItemMenu");
            actionService.AddNewAction(2, "Bieganie", "AddNewItemMenu");
            actionService.AddNewAction(3, "Ćwiczenia", "AddNewItemMenu");

            return actionService;
        }
    }
}
