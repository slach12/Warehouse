using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class Item
    {
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
