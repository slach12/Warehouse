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

            //Test
            bool loop = true;

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
                        var removeId = itemManager.RemoveItem();
                        break;
                    case '3':
                        var detailId = itemManager.DetailViewItem();
                        break;
                    case '4':
                        var typeId = itemManager.ByTypeIdViewItem(); 
                        break;
                    default:
                        Console.WriteLine("Action that you entered does not exist");
                        break;
                }

            }
        }
    }
}