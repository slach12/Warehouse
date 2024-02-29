using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Domain.Common;
using Warehouse.Domain.Entity;

namespace Warehouse.App.Concrete
{
    public class MenuActionService : BaseService<MenuAction>
    {

        public MenuActionService() 
        { 
            Initialize();
        }  

        public List<MenuAction> GetMenuActionsByMenuName(string menuName) 
        {
            List<MenuAction> result = new List<MenuAction>();
            foreach (var menuAction in Items)
            {
                if (menuAction.MenuName == menuName)
                {
                    result.Add(menuAction);
                }
            }
            return result;
        }


        private void Initialize()
        {
            
            AddItem(new MenuAction( 1, "Add item", "Menu"));
            AddItem(new MenuAction(2, "Remove item", "Menu"));
            AddItem(new MenuAction(3, "Show details", "Menu"));
            AddItem(new MenuAction(4, "List of items", "Menu"));


            AddItem(new MenuAction(1, "Clothing", "AddNewItemMenu"));
            AddItem(new MenuAction(2, "Electronics", "AddNewItemMenu"));
            AddItem(new MenuAction(3, "Grocery", "AddNewItemMenu"));

        }
    }
}
