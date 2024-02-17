using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class ClothingItem : Item
    {
        public DateTime ExploryDate { get; set; }
        public ClothingItem(int id, string name) : base(id, name)
        { }

        public new void ShowDetails()
        {
            Console.WriteLine("Cloth");
            base.ShowDetails();
            //Console.WriteLine($"Item Explorty Date is : {ExploryDate.ToShortDateString()}");
        }

        public override void ChangeQuantity(int quantity)
        {
            Quantity = quantity;
            if (Quantity < 5)
            {
                isLowInWarehouse = true;
            }
        }
    }

    public class GroceryItem : Item
    {
        public DateTime ExploryDate { get; set; }
        public GroceryItem(int id, string name) : base(id, name)
        { }

        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"Item Explorty Date is : {ExploryDate.ToShortDateString()}");
        }

        public override void ChangeQuantity(int quantity)
        {
            Quantity = quantity;
            if (Quantity < 50)
            {
                isLowInWarehouse = true;
            }
        }
    }


    public class AuditableModel
    {
        public int CreatedById { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int? ModifatedById { get; set; }
        public DateTime ModifatedDateTime { get; set; }


    }

    public interface IItem
    {
        int Id { get; }
        string Name { get; set; }
        int TypeId { get; set; }
        int Quantity { get; set; }
        bool IsLowInWarehouse { get; set; }

        public void ChangeQuantity(int quantity)
        {
            Quantity = quantity;
            if (Quantity < 50)
            {
                IsLowInWarehouse = true;
            }
        }
    }
    public  class Item : AuditableModel
    {
        public virtual void ShowDetails()
        {
            Console.WriteLine($"Item id is : {Id}");
            Console.WriteLine($"Item name is : {Name}");
        }

        protected int Quantity;
        protected bool isLowInWarehouse;

        public virtual void ChangeQuantity(int quantity)
        {
            Quantity = quantity;
            if (Quantity < 50)
            {
                isLowInWarehouse = true;
            }
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
