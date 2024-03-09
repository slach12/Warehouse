using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Domain.Common;

namespace Warehouse.Domain.Entity
 
{
    public  class Item : BaseEntity
    {

        public int Quantity;
        protected bool isLowInWarehouse;
        public string Name { get; set; }
        public int TypeId { get; set; }

        public Item(int id,string name, int typeId) 
        {
            Name = name;
            TypeId = typeId;
            Id = id;
        }

        public Item() 
        { 
        
        }


    }
}
