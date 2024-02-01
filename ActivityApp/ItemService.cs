using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityApp
{
    public class ItemService
    {
        public List<Item> Items;

        public ItemService() 
        {
            Items = new List<Item>();
        }    

        public ConsoleKeyInfo AddNewItemView(MenuActionService actionService)
        {
            var addNewItemMenu = actionService.GetMenuActionsByMenuName("AddNewItemMenu");
            Console.WriteLine();
            Console.WriteLine("Wybierz typ aktywności: ");

            for (int i = 0; i < addNewItemMenu.Count; i++) 
            {
                Console.WriteLine($"{addNewItemMenu[i].Id}. {addNewItemMenu[i].Name}");
            }

            var operation = Console.ReadKey();
            return operation;
        }

        public int AddNewItem(char itemType)
        {
            int itemTypeId;
            Int32.TryParse(itemType.ToString(), out itemTypeId);    
            Item item = new Item();
            item.TypeId = (ItemTypes)itemTypeId;
            Console.WriteLine();
            Console.WriteLine("Podaj id dla nowej aktywności:");
            var id = Console.ReadLine();
            int itemId;
            Int32.TryParse(id, out itemId);
            Console.WriteLine("Podaj nazwę dla aktywności:");
            var name = Console.ReadLine();

            Console.WriteLine("Podaj ilość aktywności:");
            Console.WriteLine("Pływanie  - liczba przepłyniętych basenów (25 m)");
            Console.WriteLine("Bieganie  - pokonany dystans w kilometrach");
            Console.WriteLine("Ćwiczenie - ilość wykonanych powtórzeń");
            double quantity;
            Double.TryParse(Console.ReadLine(),out quantity);
            Console.WriteLine("Podaj czas jaki zajeło wykonanie aktywności w minutach:");
            double activityTime;
            Double.TryParse(Console.ReadLine(), out activityTime);
            Console.WriteLine("Podaj wagę w dniu aktywności");
            double weight;
            Double.TryParse(Console.ReadLine(), out weight);

            item.Id = itemId;
            item.Name = name;
            item.Weight = weight;
            item.Quantity = quantity;
            item.ActivtyTime = activityTime;
            item.ActivityDate = DateTime.Now;


            
            Items.Add(item);
            return itemId;


        }

        public int RemoveItemView()
        {
            Console.WriteLine("Wprowadź id aktywności, którą chcesz usunąć:");
            var itemId = Console.ReadKey();
            int id;
            Int32.TryParse(itemId.KeyChar.ToString(), out id);  


            return id;
        }

        public void RemoveItem(int removeId)
        {
            Item activityToRemove = new Item();
            foreach (var item in Items)
            {
                if (item.Id == removeId)
                {
                    activityToRemove = item;
                    break;
                }
            }
            Items.Remove(activityToRemove);
        }

        public int ItemDetailSelectionView()
        {
            Console.WriteLine("Wprowadź id aktywności, którą chcesz pokazać:");
            var itemId = Console.ReadKey();
            int id;
            Int32.TryParse(itemId.KeyChar.ToString(), out id);


            return id;
        }
        public int  ItemTypeSelectionView()
        {
            Console.WriteLine("Podaj id typu aktywności , które chcesz wyświetlić:");
            Console.WriteLine("1 - pływanie");
            Console.WriteLine("2 - bieganie");
            Console.WriteLine("3 - ćwiczenia");
            Console.WriteLine("4 - Wszystkie typy aktywności");
            var itemId = Console.ReadKey();
            int id;
            Int32.TryParse(itemId.KeyChar.ToString(), out id);
            return id;
        }
        public void ItemDetailView(int detailId)
        {
            Item activityToShow = new Item();
            foreach(var item in Items)
            {
                if(item.Id == detailId)
                {
                    activityToShow = item;
                    break;
                }
            }
            Console.WriteLine($"Id aktywności    : {activityToShow.Id}");
            Console.WriteLine($"Nazwa aktywności : {activityToShow.Name}");
            Console.WriteLine($"Data aktywności  : {activityToShow.ActivityDate}");
            Console.WriteLine($"Typ aktywności   : {activityToShow.TypeId}");
            Console.WriteLine($"Ilość   : {activityToShow.Quantity} {activityToShow.Unit} w czasie {activityToShow.ActivtyTime} minuty");
            Console.WriteLine($"Waga w dniu aktywności : {activityToShow.Weight}");
        }

        public void ItemByTypeIdView(int typeId)
        {
            List<Item> toShow = new List<Item>();
            foreach (var item in Items)
            {
                if (item.Id == typeId || typeId == (int)ItemTypes.All)
                {
                    toShow.Add(item);
                }
            }
            
            foreach(var item in toShow)
            {
                Console.WriteLine($"Id : {item.Id} | Name : {item.Name}");
            }

            
        }
    }
}
