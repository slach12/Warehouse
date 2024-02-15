using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{


    public class GroceryItem : Item
    {
        public DateTime ExploryDate { get; set; }
        public GroceryItem(int id, string name) : base(id, name)
        { }

        public void ShowDetails()
        {
            base.ShowDetails();

            Console.WriteLine($"Item Explorty Date is : {ExploryDate.ToShortDateString()}");

        }



    }


    public class AuditableModel
    {
        public int CreatedById { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int? ModifatedById { get; set; }
        public DateTime ModifatedDateTime { get; set; }


    }

    public class Item : AuditableModel
    {
        public void ShowDetails()
        {
            Console.WriteLine($"Item id is : {Id}");
            Console.WriteLine($"Item name is : {Name}");
        }
        public Item(int id ,string name)
        {
            Id = id;    
            Name = name;    
        }

        public Item()
        {

        }



        private int _id;
      //  public int Id => _id; //odpowiednik -> public int Id { get { return _id; } }
        public void setId(int id)
        {
            _id = id;
        }
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int TypeId { get; set; }

    }
}
