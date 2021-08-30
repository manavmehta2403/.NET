using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myInvt = new List<Car>()
            {
                new Car() {VIN ="A26", Maker ="Honda", Model = "CR-V", Year = 2012, Color = "White"},
                new Car() {VIN ="Z1", Maker ="Chevy", Model = "Cammaro", Year = 2000, Color = "Black"},
                new Car() {VIN ="M24", Maker ="Nissan", Model = "GT-R", Year = 2019, Color = "Matte_Black"},
                new Car() {VIN ="F1", Maker ="Ferrari", Model = "250 GT", Year = 1982, Color = "Red"},
                new Car() {VIN ="G25", Maker ="Honda", Model = "BrV", Year = 2018, Color = "Brown"},
                new Car() {VIN ="D18", Maker ="Chevy", Model = "Beat", Year = 2016, Color = "Black"}
            };
            Console.WriteLine(myInvt.GetType());
            Console.WriteLine("Cool");
            //LINQ ==> Query
            var honda = from car in myInvt
                        where car.Maker == "honda"
                        orderby car.Year
                        select new { car.Maker, car.Year };
            foreach (var i in honda)
            {
                Console.WriteLine(i.Year + " "  + " " + i.Maker);
            }
            Console.WriteLine("Cool");

            //Lamda

            //myInvt.ForEach(i => Console.WriteLine(i.Model + " " + i.Maker));

            var nissan = myInvt.Where(p => p.Maker == "Nissan");
            //foreach (var i in nissan)
            //{
            //    Console.WriteLine(i.Model + " " + i.Maker);
            //}
            var car_order = myInvt.OrderBy(l => l.Color);
            //foreach (var i in car_order)
            //{
            //    Console.WriteLine(i.Color + " " + i.Maker + " " + i.Model);
            //}
            

            var latestChevy = myInvt.OrderByDescending(l => l.Year).
                First(l => l.Maker == "Chevy");
            //Console.WriteLine(latestChevy.Color + " " + latestChevy.Maker + " " + latestChevy.Model);


            var Ford = myInvt.Exists(p => p.Maker == "Ford");

                Console.WriteLine(myInvt.TrueForAll(p => p.Year > 1980));
                Console.WriteLine(myInvt.TrueForAll(p => p.Maker == "Ferrari"));
                Console.WriteLine(myInvt.Max(p => p.Year));

            var query = myInvt.Take(3);
            foreach(var i in query)
            {
                Console.WriteLine(i.Model);
            }

            Console.ReadKey();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Maker { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car(string vin, string maker, string model, int year, string color)
        {
            this.VIN = vin;
            this.Maker = maker;
            this.Model = model;
            this.Year = year;
            this.Color = color;
        }
        public Car()
        {
            VIN = null;
            Maker = null;
            Model = null;
            Year = 0;
            Color = null;
        }
    }
}
