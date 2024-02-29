using System;
using Warehouse.App.Concrete;
using Warehouse.App.Managers;
using Warehouse.Domain.Entity;
using Warehouse.Helpers;


namespace Warehouse
{
    public class Program
    {

        public const string FILE_NAME = @"C:\Warehouse\ImportFile.xlsx";
        static void Main(string[] args)
        {
            MenuActionService actionService = new MenuActionService();
            //ItemService itemService = new ItemService();
            ItemManager itemManager = new ItemManager(actionService);
            Console.WriteLine("Witaj w programie warehouse.");

            
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
                        var newId = itemManager.AddNewItem();
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

                GenericService<Item> genericItemService = new GenericService<Item>();
                Item itemForGeneric = new Item(1, "Apple");
                Item item2ForGeneric = new Item(2, "Strawberry");

                genericItemService.Add(itemForGeneric);
                genericItemService.Add(item2ForGeneric);

                var items = genericItemService.GetAll();
                genericItemService.Remove(itemForGeneric);


                GenericService<MenuAction> genericActionService = new GenericService<MenuAction>();
                MenuAction menuAction = new MenuAction(1,"Generic test");
                genericActionService.Add(menuAction);

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


    }
}