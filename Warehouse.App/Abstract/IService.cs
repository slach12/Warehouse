﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Domain.Abstract
{
    public interface IService<T>
    {
        List<T> Items { get; set; }
        public List<T> GetAllItems();
        int AddItem(T item);
        int UpdateItem(T item);
        void RemoveItem(T item);
    }
}
