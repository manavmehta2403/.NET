using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CarInventerory
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.VIN = "A26";
            myCar.Version = new DateTime(2012,3,12).Year;
            myCar.Maker = "Honda";
            myCar.Model = "CR-V";
            myCar.Color = "Black";

            Console.Write($"{myCar.Maker} {myCar.Model} " +
                $"{myCar.Color} {myCar.Version}");

            Console.WriteLine(" {0:C}", myCar.Value(myCar));

            Console.WriteLine("{0}", Discontinue(myCar) ? "New" : "Old");

            ///////////////////////////////////////////////////////////

            Car otherCar = new Car("Ferrari","250 GT", Convert.ToInt32(new DateTime(1982,02,3).Year), "Red","Z1");

            Console.Write($"{otherCar.Maker} {otherCar.Model} " +
                $"{otherCar.Color} {otherCar.Version}");

            Console.WriteLine(" {0:C}", otherCar.Value(otherCar));

            Console.WriteLine("{0}", Discontinue(otherCar) ? "New" : "Old");

            ////////////////////////////////////////////////////
            
            List<Car> ele = new List<Car>() { myCar, otherCar };

            foreach( Car c in ele)
            {
                Console.WriteLine(c.Maker);
            }

            ///////////////////////////////////////////////////

            Dictionary<string, Car> dt = new Dictionary<string, Car>();
            dt.Add(myCar.VIN, myCar);
            dt.Add(otherCar.VIN, otherCar);

            foreach (KeyValuePair<string,Car> kv in dt )
            {
                Console.WriteLine($"{kv.Key}-->{kv.Value.Model}");
            }

            Console.ReadKey();

        }

        static bool Discontinue(Car car)
        {
            bool boolean;

            if (car.Version < 2012)
            {
                boolean = true;
            }
            else
            {
                boolean = false;
            }

            return boolean;
        }

    }

    class Car
    {
        public string Maker { get; set; }
        public string Model { get; set; }
        public int Version 
        {
            get;
            
            
            set;
        }
        public string Color { get; set; }
        public string VIN { get; set; }

        public Car(string maker, string model, int version, string color, string vin)
        {
            Maker = maker;
            Model = model;
            Version = version;
            Color = color;
            VIN = vin;
        }
        public Car()
        {
            Maker = null;
            Model = null;
            Version = 0;
            Color = null;
            VIN = null;
        }
        public decimal Value(Car car)
        {
            decimal price = 7000000M;

            return price;
        }
    }
}
