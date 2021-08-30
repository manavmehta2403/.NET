using ClassesLib;
using CarClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesLib
{
    public class Store
    {
        public List<Car> Inventory { get; set; }
        public List<Car> Shopping { get; set; }

        public Store()
        {
            Inventory = new List<Car>();
            Shopping = new List<Car>();
        }

        public decimal Checkout()
        {
            decimal total = 0.00M;

            foreach(var s in Shopping)
            {
                total += s.Price;
            }

            Shopping.Clear();
            return total;
        }
    }
}
