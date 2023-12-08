﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class MenuActionService
    {
        private List<MenuAction> menuActions;
        
        public MenuActionService()
        {
            menuActions = new List<MenuAction>(); 
        }
        
        public void AddNewAction(int id, string name,string menuName)
        {
            MenuAction menuAction = new MenuAction() { Id = id, MenuName = menuName, Name = name    };
            menuActions.Add(menuAction);
        }

        public List<MenuAction> GetMenuActionsByMenuName(string menuName) 
        {
            List<MenuAction> result = new List<MenuAction>();
            foreach (var menuAction in menuActions)
            {
                if (menuAction.MenuName == menuName)
                {
                    result.Add(menuAction);
                }
            }
            return result;
        }
    }
}
