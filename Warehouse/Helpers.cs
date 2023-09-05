using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class Helpers
    {
        public int GiveNumber()
        {
            SomeStructure stru = new SomeStructure();

            int number = 5;
            char character = 'i';
            bool isTrue = false;
            return number;
        }

        public enum ItemTypes
        {
            Grocery,
            Clothing,
            Electronics
        }

        public struct SomeStructure
        {
            public int numberForStructure;
            private string nameOfStructure;
            public SomeStructure(int number, string name)
            {
                this.numberForStructure = number;
                this.nameOfStructure = name;
            }    
        }
    }
}
