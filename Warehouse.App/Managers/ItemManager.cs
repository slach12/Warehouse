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

        public ItemManager(MenuActionService actionService,ItemService itemService)
        {
            _itemService = itemService;
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

        public int RemoveItem()
        {
            Console.WriteLine("Please enter ID for item you want to remove:");
            var itemId = Console.ReadKey();
            Console.ReadLine();
            int removeId;
            Int32.TryParse(itemId.KeyChar.ToString(), out removeId);

            Item productToRemove = new Item();
            foreach (var item in _itemService.Items)
            {
                if (item.Id == removeId)
                {
                    productToRemove = item;
                    break;
                }
            }
            _itemService.RemoveItem(productToRemove);
  
            return removeId;
        }


        public int DetailViewItem()
        {
            Console.WriteLine("Please enter ID for item you want to show:");
            var itemId = Console.ReadKey();
            Console.ReadLine();
            int detailId;
            Int32.TryParse(itemId.KeyChar.ToString(), out detailId);
            Item productToShow = new Item();
            foreach (var item in _itemService.Items)
            {
                if (item.Id == detailId)
                {
                    productToShow = item;
                    break;
                }
            }
            Console.WriteLine($"Item id : {productToShow.Id}");
            Console.WriteLine($"Item name : {productToShow.Name}");
            Console.WriteLine($"Item type id : {productToShow.TypeId}");
            return detailId;
        }



        public int ByTypeIdViewItem()
        {
            Console.WriteLine("Please enter Type iD for item you want to show:");
            var itemId = Console.ReadKey();
            Console.ReadLine();
            int typeId;
            Int32.TryParse(itemId.KeyChar.ToString(), out typeId);
            List<Item> toShow = new List<Item>();
            foreach (var item in _itemService.Items)
            {
                if (item.TypeId == typeId)
                {
                    toShow.Add(item);
                }
            }
            Console.WriteLine($"Znaleziono {toShow.Count} elementów");

            return typeId;
        }

        public Item GetItemById( int id )
        {
            var item = _itemService.GetItemById( id );
            return item;
        }


    }
}
