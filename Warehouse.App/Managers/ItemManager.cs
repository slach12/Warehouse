using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Warehouse.App.Concrete;
using Warehouse.Domain.Entity;

namespace Warehouse.App.Managers
{
    public class ItemManager
    {

        private readonly MenuActionService _actionService;
        private ItemService _itemService;
        public ItemManager(MenuActionService actionService)
        {
            _itemService = new ItemService();
            _actionService = actionService;
        }

        public int AddNewItem()
        {
            var addNewItemMenu = _actionService.GetMenuActionsByMenuName("AddNewItemMenu");
            Console.WriteLine("Please select item type: ");
            for (int i = 0; i < addNewItemMenu.Count; i++)
            {
                Console.WriteLine($"{addNewItemMenu[i].Id}. {addNewItemMenu[i].Name}");
            }
            var operation = Console.ReadKey();
            int typeId;
            Int32.TryParse(operation.KeyChar.ToString(), out typeId);

            Console.WriteLine("Podaj nazawę dla produktu:");
            var name = Console.ReadLine();
            var lastId = _itemService.GetLastId();
            Item item = new Item(lastId+1,name , typeId);
            _itemService.AddItem(item);
            return item.Id;
        }
    }
}
