﻿using System;
using static Warehouse.Helpers;

namespace Warehouse
{
    public class Program
    {

        public const string FILE_NAME = @"C:\Warehouse\ImportFile.xlsx";
        static void Main(string[] args)
        {


            MenuActionService actionService = new MenuActionService();
            actionService = Initialize(actionService);
            ItemService itemService = new ItemService();
            Console.WriteLine("Witaj w programie warehouse.");

            itemService.ShowDifferentItems();

            bool loop = false;

            while (loop)
            {
                Console.WriteLine("Co chcesz wybrać ? : ");
                var mainMenu = actionService.GetMenuActionsByMenuName("Menu");
                /*        foreach (var item in  mainMenu)
                        {
                            Console.WriteLine($"{item.Id}. {item.Name} ");
                        }*/
                Console.WriteLine("Menu:");
                for (int i = 0; i < mainMenu.Count; i++)
                {
                    Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
                }

                var operation = Console.ReadKey();
                Console.WriteLine();
                

                switch (operation.KeyChar)
                {
                    case '1':
                        var keyInfo = itemService.AddNewItemView(actionService);
                        var id = itemService.AddNewItem(keyInfo.KeyChar);
                        var id2 = itemService.AddNewItem(keyInfo.KeyChar, 6);
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
                        var typeId = itemService.ItemTypeSelectionView();
                        itemService.ItemsByTypeIdView(typeId);
                        break;
                    default:
                        Console.WriteLine("Action that you entered does not exist");
                        break;
                }
            }
            /* Console.WriteLine("Welcome to warehouse app!");
              Console.WriteLine("Please let me know what you want to do:");
              Console.WriteLine("1. Add Item");
              Console.WriteLine("2. Remove Item");
              Console.WriteLine("3. Check Item");
              Console.WriteLine("Press 1,2 or 3...");

              string category = Console.ReadLine();
              ItemType chosenCategory;

              Enum.TryParse(category, out chosenCategory);*/


        }

        private static MenuActionService Initialize(MenuActionService actionService)
        {
            actionService.AddNewAction(1, "Add item", "Menu");
            actionService.AddNewAction(2, "Remove item", "Menu");
            actionService.AddNewAction(3, "Show details", "Menu");
            actionService.AddNewAction(4, "List of items", "Menu");


            actionService.AddNewAction(1, "Clothing", "AddNewItemMenu");
            actionService.AddNewAction(2, "Electronics", "AddNewItemMenu");
            actionService.AddNewAction(3, "Grocery", "AddNewItemMenu");

            return actionService;
        }
    }
}