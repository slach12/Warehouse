using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public static class Helpers
    {
        public static int GiveNumber()
        {
            SomeStructure stru = new SomeStructure();

            int number = 5;
            char character = 'i';
            bool isTrue = false;
            return number;
        }

        public static int KgToG(int kgCount)
        {
            return kgCount * 1000;
        }
    }

    public enum ItemType
    {
        Grocery= 1,
        Clothing,
        Electronics
    }

    public enum Weekday
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public enum ReportFrequency
    {
        Weekly = 7,
        Biweekly = 14,
        Quarely = 90
    }
    public class ItemServices
    {
        public ItemServices()
        {
        }

        public void AddItem()
        { }

        public void RemoveItem() 
        { }
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
