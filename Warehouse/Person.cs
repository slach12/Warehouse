using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class Person
    {
        public string Sex { get; set; } 
        public string HairColor { get; set; }
        public decimal Height {  get; set; }
        public decimal Width { get; set; }

        public int Power {  get; set; }

        public void Eat(string foodName)
        {
            Power += 20;
        }

        public void Walk()
        {

        }

        public void Sleep()
        {

        }
    }
}
