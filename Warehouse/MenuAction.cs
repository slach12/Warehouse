using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class MenuAction
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string MenuName {  get; set; }
        public MenuAction():this(1,"Bieganie")
        {
        
        }

        public MenuAction(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}
