using CarClass;
using ClassesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConsole
{
    class Program
    {

        public static void Main(string[] args)
        {
            Store st = new Store();
            Console.WriteLine("Welcome to the WuH's Car Services where we you can buy new Cars.");

            char action = ChooseAction();
            int cartheft = 0;
            while (action != 'q')
            {

                switch (action)
                {
                    case 'a':
                        try
                        {
                            Console.WriteLine("Please enter the name of the car. Ex:- 911 Turbo");
                            string carModel = Console.ReadLine();
                            Console.WriteLine("Who is the maker of this model? Ex:- Porsche");
                            string carMaker = Console.ReadLine();
                            Console.WriteLine("Please enter the vechile indentification number. Ex:- Numerals");
                            int carVIN = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Please enter the year of manufacture. YYYY as digits");
                            DateTime carYear = DateTime.ParseExact(Console.ReadLine(), "yyyy", null);
                            Console.WriteLine("Please enter the car price.");
                            decimal carPrice = Convert.ToInt32(Console.ReadLine());
                            foreach (var checkVin in st.Inventory)
                            {
                                if (carVIN == checkVin.VIN)
                                {
                                    Console.WriteLine("Please make sure your VIN is correct, as it is already registered.");
                                    cartheft = cartheft++;

                                    if (cartheft > 1)
                                    {
                                        Console.WriteLine("System detect the theft.");
                                        break;
                                    }
                                    else
                                    {
                                        goto case 'a';
                                    }
                                }
                            }

                            Car car = new Car(carModel, carMaker, carVIN, carYear, carPrice);

                            st.Inventory.Add(car);

                            printIn(st);
                        }

                        catch (FormatException e)
                        {

                            Console.WriteLine(e.Message);
                        }

                        break;

                    case 's':
                        if (!st.Inventory.Any())
                        {
                            Console.WriteLine("There is no car in the warehouse.");
                        }
                        else
                        {
                            Console.WriteLine("You have choosen to add the car in the cart");
                            printIn(st);
                            Console.WriteLine("Please enter the vechile indentification number.");
                            try
                            {
                                int shopVIN = Convert.ToInt32(Console.ReadLine());

                                for (int i = 0; i < st.Inventory.Count(); i++)
                                {
                                    if (shopVIN == st.Inventory[i].VIN)
                                    {
                                        st.Shopping.Add(st.Inventory[i]);
                                        st.Inventory.Remove(st.Inventory[i]);
                                    }
                                }
                            }
                            catch (FormatException e)
                            {

                                Console.WriteLine(e.Message);
                            }
                        }
                        printIn(st);
                        printSh(st);
                        break;

                    case 'c':
                        printSh(st);
                        Console.WriteLine("The total cost is $" + st.Checkout());
                        break;

                    default:
                        break;

                }
                action = ChooseAction();
            }
            Console.ReadKey();
        }

        public static char ChooseAction()
        {
            char choice = '\0';
            Console.WriteLine("Choose a service.\n\t(A)dd\n\t(S)hop\n\t(C)heckout\n\t(Q)uit.");
            try
            {
                choice = Convert.ToChar(Console.ReadLine().ToLower());
                if (choice != 'a' && choice != 's' && choice != 'c' && choice != 'q')
                {
                    throw new IndexOutOfRangeException("Please enter correct choice!");
                }
            }
            catch (IndexOutOfRangeException e)
            {

                Console.WriteLine(e.Message);
            }
            return choice;

        }

        public static void printIn(Store s)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Inventory");
            Console.WriteLine(String.Format("{0,-10} {1,-10} {2,10} {3,10} {4,10}", "Model", "Manufacture", "VIN", "Year", "Price"));
            foreach (var c in s.Inventory)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("\n");
        }
        public static void printSh(Store s)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Cart");
            Console.WriteLine(String.Format("{0,-10} {1,-10} {2,10} {3,10} {4,10}", "Model", "Manufacture", "VIN", "Year", "Price"));
            foreach (var c in s.Shopping)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("\n");
        }
    }
}
