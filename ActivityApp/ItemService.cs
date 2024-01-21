﻿using System;
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
            item.TypeId = itemTypeId;
            Console.WriteLine();
            Console.WriteLine("Podaj id dla nowej aktywności:");
            var id = Console.ReadLine();
            int itemId;
            Int32.TryParse(id, out itemId);
            Console.WriteLine("Podaj nazwę dla aktywności:");
            var name = Console.ReadLine();

            item.Id = itemId;
            item.Name = name;
            
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
            Console.WriteLine($"Item id : {activityToShow.Id}");
            Console.WriteLine($"Item name : {activityToShow.Name}");
            Console.WriteLine($"Item type id : {activityToShow.TypeId}");
        }
    }
}
