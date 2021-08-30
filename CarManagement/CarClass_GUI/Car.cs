using System;
using ClassesLib;
using CarClass;

namespace CarClass
{
    public class Car
    {
        public string Model { get; set; }
        public string Maker { get; set; }
        public int VIN { get; set; }
        public DateTime Year { get; set; }
        public decimal Price { get; set; }


        public Car()
        {
            Model = null;
            Maker = null;
            int? VIN = null;
            DateTime? Year = null;
            Price = 0.00M;
        }

        public Car(string model, string maker, int vin, DateTime year, decimal price)
        {
            Model = model;
            Maker = maker;
            VIN = vin;
            Year = year;
            Price = price;
        }

        public override string ToString()
        {
            return String.Format("{0,-10} {1,-10} {2,10} {3,10} {4,10}", Model, Maker, VIN, Year.Year, "$" + Price);
        }
    }
}
