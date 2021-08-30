using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //Console.WriteLine("Choose something");
            //Console.Write("1,2,3 \t");

            ////Descision
            //var doors = Console.ReadLine();

            //if (doors == "1")
            //{
            //    Console.WriteLine($"Won");
            //}
            //else if (doors == "2")
            //{
            //    Console.WriteLine($"Fish");
            //}
            //else if (doors == "3")
            //{
            //    Console.WriteLine($"Fish");
            //}
            //else
            //{
            //    Console.WriteLine($"Nope we dont know that.");
            //}

            //Console.WriteLine("y/n Continue one more time");
            //var conti = Console.ReadLine() == "y" ? "Run again" : "Bye";
            //Console.WriteLine($"{conti}");

            //switch (conti)
            //{
            //    case "Run again":
            //        Console.WriteLine("Choose something");
            //        Console.Write("1,2,3 \t");

            //        //Descision
            //        doors = Console.ReadLine();
            //        if (doors == "1")
            //        {
            //            Console.WriteLine($"Won");
            //        }
            //        else if (doors == "2")
            //        {
            //            Console.WriteLine($"Fish");
            //        }
            //        else if (doors == "3")
            //        {
            //            Console.WriteLine($"Fish");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Nope we dont know that.");
            //        }

            //        break;
            //    default:
            //        Console.WriteLine($"{conti}");
            //        break;

            //}

            //for (var i = 0; i <= 10; i++)
            //{

            //    if (i == 5)
            //        continue;
            //    else if (i == 10)
            //        break;

            //    Console.WriteLine(i);
            //}


            Object[] var = new object[] { 1, 2, 3 };

            foreach (Object v in var)
            {
                Console.WriteLine($"{v}");
            }

            while (true)
            {
                Console.WriteLine("Chooser");
                Console.WriteLine("(D)ine");
                Console.WriteLine("(T)ake away");
                Console.WriteLine("(P)arcel");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "D":
                        Console.WriteLine("Food will be " + "" +
                            "served at your table.");
                        break;

                    case "T":
                        Console.WriteLine("Food will be " + "" +
                            "available at drive-thru");
                        break;

                    case "P":
                        Console.WriteLine("Food will be " + "" +
                            "deliver at your door step");
                        break;

                    default:
                        continue;
                }
                break;

            }

            Console.ReadKey();
        }
    }
}
