using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{

    public class GenericService<T> where T : class
    {
        public List<T> Items { get; set; }   
        public GenericService() 
        {
            Items = new List<T>();
        }

        public List<T> GetAll()
        {
            return Items;
        }

        public void Add(T item)
        {
            Items.Add(item);

        }

        public void Remove(T item)
        {
            Items.Remove(item);
        }



    }

    public class ItemService
    {

        //public List<Item> Items {  get; set; }
        public List<Item> Items;
        public ItemService()
        {
            Items = new List<Item>();
 
        }


        public int AddGroceryItem(int id, string name ,int typeId)
        {

            GroceryItem groeryItem = new GroceryItem(id,name);   
            groeryItem.Id = id;
            groeryItem.Name = name; 
            groeryItem.ExploryDate = DateTime.Now;  

          /*  Item item = new Item();
            item.Explo*/
              
            return 0;
        }


        public ConsoleKeyInfo AddNewItemView(MenuActionService actionService)
        {
            var addNewItemMenu = actionService.GetMenuActionsByMenuName("AddNewItemMenu");
            Console.WriteLine("Please select item type: ");
            for (int i = 0; i < addNewItemMenu.Count; i++)
            {
                Console.WriteLine($"{addNewItemMenu[i].Id}. {addNewItemMenu[i].Name}");
            }
            var operation = Console.ReadKey();
            Console.WriteLine();

            return operation;
        }

        public int AddNewItem(char itemType)
        {
            int itemTypeId;
            Int32.TryParse(itemType.ToString(), out itemTypeId);    
            Item item = new Item();
            item.TypeId = itemTypeId;
            Console.WriteLine("Please enter id for new item:");
            var id = Console.ReadLine();
            int itemId;
            Int32.TryParse(id, out itemId);
            Console.WriteLine("Please enter name for new item:");
            var name = Console.ReadLine();  
            
            item.Id = itemId;
            item.Name = name;
            Items.Add(item);
            return itemId;

        }



        public int AddNewItem(char itemType , int id)
        {
            int itemTypeId;
            Int32.TryParse(itemType.ToString(), out itemTypeId);
            Item item = new Item();
            item.TypeId = itemTypeId;
          
            Console.WriteLine("Please enter name for new item:");
            var name = Console.ReadLine();
            item.Id = id;
            item.Name = name;
            Items.Add(item);
            return id;
        }


        public int RemoveItemView()
        {
            Console.WriteLine("Please enter ID for item you want to remove:");
            var itemId = Console.ReadKey();
            Console.ReadLine();
            int id;
            Int32.TryParse(itemId.KeyChar.ToString(), out id);

            return id;


        }

        public List<Item> GetAllItems()
        {
            return Items;   
        }

      /*  public  int AddNewItem(int id , string name = "Apple")
        {
            Item item = new Item() { Id = id, Name = name};
            Items.Add(item);
            return item.Id;
        }
*/
        public int Method(int id , out string name)
        {
            name = "New name";
            return id;
        }

        internal void RemoveItem(int removeId)
        {
            Item productToRemove = new Item();
            
            foreach (var item in Items)
            {
                if(item.Id == removeId)
                {
                    productToRemove = item;
                    break;
                }
            }
            Items.Remove(productToRemove);
        }

        public void ItemDetailView(int detailId)
        {
            Item productToShow = new Item();
            foreach(var item in Items)
            {
                if(item.Id == detailId)
                {
                    productToShow = item;
                    break;
                }
            } 
            Console.WriteLine($"Item id : {productToShow.Id}");
            Console.WriteLine($"Item name : {productToShow.Name}");
            Console.WriteLine($"Item type id : {productToShow.TypeId }");
        }

        public int  ItemDetailSelectionView()
        {
            Console.WriteLine("Please enter ID for item you want to show:");
            var itemId = Console.ReadKey();
            Console.ReadLine();
            int id;
            Int32.TryParse(itemId.KeyChar.ToString(), out id);
            return id;
        }

        public int ItemTypeSelectionView()
        {
            Console.WriteLine("Please enter Type iD for item you want to show:");
            var itemId = Console.ReadKey();
            Console.ReadLine();
            int id;
            Int32.TryParse(itemId.KeyChar.ToString(), out id);
            return id;
        }

        public void ItemsByTypeIdView(int typeId)
        {
            List<Item> toShow = new List<Item>();
            foreach(var item in Items) {
                if(item.TypeId == typeId)
                {
                    toShow.Add(item);
                }
            }

            Console.WriteLine($"Znaleziono {toShow.Count} elementów");
            
        }


        public int ShowDifferentItems()
        {
            Item item = new Item(1,"Item");
            GroceryItem groceryItem = new GroceryItem(2, "apple");
            ClothingItem clothingItem = new ClothingItem(3, "Shirt");
            List<Item> items = new List<Item>();
            items.Add(item);
            items.Add(groceryItem);
            items.Add(clothingItem);

            foreach(var it in items)
            {
                if (it is ClothingItem)
                {
                    ClothingItem cloItem = (ClothingItem) it;
                    cloItem.ShowDetails();
                }
                else
                {
                    it.ShowDetails();
                }
                

            }

            return 0;
        }

    }
}
