using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Aircraft
    {
        //declare the 'fields'
        protected double airspeed;
        protected double altitude;
        protected double heading;


        //get method as the properties
        //as get methods
        public double GetAirspeed
        {
            get
            {
                return airspeed;
            }
        }
        public double GetAltitude
        {
            get
            {
                return altitude;
            }
        }
        public double GetHeading
        {
            get
            {
                return heading;

            }
        }

        //For right turn the heading increases by 10
        public double TurnRight()
        {
            if (heading >= 0 && heading <= 359)
            {
                heading += 10;
            }
            return heading;
        }

        //For right turn the heading decrease by 10
        public double TurnLeft()
        {
            if (heading >= 0 && heading <= 359)
            {
                heading -= 10;
            }
            return heading;
        }

        //for the altitude increase as we climb
        public double Climb()
        {
            altitude += 100;
            return altitude;
        }

        //for the downwards altitude decreases
        public double Descend()
        {
            altitude -= 100;
            return altitude;
        }

        //abstract classes to increase spped and to print the details of the abstract class
        public abstract void IncreaseAirspeed();
        public abstract void DecreasingAirspeed();
        public abstract override string ToString();

    }

    //calling the parent class for the base class AIRPLANE
    class Airplane : Aircraft
    {
        //engine variable for the type of the engine
        private string engine;

        //to increase the speed of the aircraft
        public override void IncreaseAirspeed()
        {
            airspeed += 20;

        }

        //decrease the speed of the aircraft
        public override void DecreasingAirspeed()
        {
            airspeed -= 20;
        }

        //getting and setting the type for the engine
        public string Engine
        {
            get => engine;
            set => engine = value;
        }

        //to print the details of the aircraft 
        public override string ToString()
        {
            string dsplyr = $"Aircraft: Airplane, Engine:{engine}, Speed:{airspeed}mph, Altitude:{altitude}feet, Heading:{heading} for ";
            return dsplyr;
        }

    }

    class Helicopter : Aircraft
    {
        //number of the blades
        private int blades;

        //to increase the speed of the aircraft
        public override void IncreaseAirspeed()
        {
            airspeed += 5;

        }

        //decrease the speed of the aircraft
        public override void DecreasingAirspeed()
        {
            airspeed -= 5;
        }

        //getting and setting the values for the blades
        public int Blades
        {
            get => blades;
            set => blades = value;
        }

        //in-case if the helicopter is in the shelter
        public void Hover()
        {
            this.airspeed = 0;
            this.altitude = 0;
            this.heading = 0;
        }

        //to print the details of the aircraft 
        public override string ToString()
        {
            string dsplyr = $"Aircraft: Helicopter, Blades: {blades}, Speed:{airspeed}mph, Altitude:{altitude}feet, Heading:{heading} for ";
            return dsplyr;
        }
    }

    class Glider : Aircraft
    {
        //to increase the speed of the aircraft
        //decreade the altitude
        public override void IncreaseAirspeed()
        {
            airspeed += 5;
            altitude -= 50;

        }

        //decrease the speed of the aircraft
        //increases the altitude
        public override void DecreasingAirspeed()
        {
            airspeed -= 5;
            altitude += 25;
        }

        //to print the details of the aircraft 
        public override string ToString()
        {
            string dsplyr = $"Aircraft: Glider, Speed:{airspeed}mph, Altitude:{altitude}feet, Heading:{heading} for ";
            return dsplyr;
        }
    }

    //main class to print the details
    class Program
    {
        //main method
        static void Main(string[] args)
        {
            //menu to select the aircraft
            Console.WriteLine("Please Choose your Aircraft Number\n" +
                "1. Airplane\n" +
                "2. Helicopter\n" +
                "3. Glider\n" +
                "4. Type 0 to exit");
            
            //enter the number to choose the aircraft
            int air_vechile = Convert.ToInt32(Console.ReadLine());

            //declaring the variables
            string direction;
            string turn;
            string height;
            int speed_up;
            int speed_down;

            //to prompt the menu again and again till the user enter 0 to exit
            while (air_vechile != 0)
            {
                //switch case when air_vechile 1 is choosen
                switch (air_vechile)
                {
                    case 1:
                        //prompting user to enter the direction for heading
                        Console.WriteLine("Initially Aircraft is heading towards?");
                        direction = (Console.ReadLine()).ToUpper();

                        //creating the new object for the AIRPLANE subclass
                        var ap = new Airplane();

                        //prompting for the engine name
                        Console.WriteLine("\nName the Engine (jet or propeller).");
                        string eng = (Console.ReadLine()).ToUpper();
                        ap.Engine = eng;

                        //asking for the turns
                        Console.WriteLine("Please provide the (left/right) turn or quit");
                        turn = (Console.ReadLine()).ToUpper();

                        //prompting user again for turns till quit is entered
                        while (turn != "QUIT")
                        {
                            //in case the user enter the right turn it calls the TurnRight method form the parent class
                            if (turn == "RIGHT")
                            {
                                ap.TurnRight();
                            }
                            //in case the user enter the left turn it calls the TurnLeft method form the parent class
                            else if (turn == "LEFT")
                            {
                                ap.TurnLeft();
                            }

                            //asking again and again
                            Console.WriteLine("Please provide the (left/right) turn or quit");
                            turn = (Console.ReadLine()).ToUpper();
                        }

                        //asking the height for the flight
                        Console.WriteLine("Please provide the (up/down) height or quit");
                        height = (Console.ReadLine()).ToUpper();

                        //prompting user again for height till quit is entered
                        while (height != "QUIT")
                        {
                            //in case the user enter the up it calls the Climb method form the parent class
                            if (height == "UP")
                            {
                                ap.Climb();
                            }
                            //in case the user enter the down it calls the Descend method form the parent class
                            else if (height == "DOWN")
                            {
                                ap.Descend();
                            }

                            //asking again and again
                            Console.WriteLine("Please provide the (up/down) height or quit");
                            height = (Console.ReadLine()).ToUpper();
                        }

                        //Asking the user for how many times to increase the speed 
                        Console.WriteLine("How many time you want to increase your speed?");
                        speed_up = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < speed_up; i++)
                        {
                            ap.IncreaseAirspeed();
                        }

                        //Asking the user for how many times to decrease the speed 
                        Console.WriteLine("How many time you want to decrease your speed?");
                        speed_down = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < speed_down; i++)
                        {
                            ap.DecreasingAirspeed();
                        }

                        //printing the details of the aircraft with the direction
                        Console.WriteLine(ap.ToString() + direction);
                        break;

                    case 2:
                        //prompting user to enter the direction for heading
                        Console.WriteLine("Initially Aircraft is heading towards?");
                        direction = (Console.ReadLine()).ToUpper();

                        //creating the new object for the Helicopter subclass
                        var heli = new Helicopter();
                        Console.WriteLine("\nEnter the number of the blades.");

                        //prompting for number of the blades
                        int bld = Convert.ToInt32(Console.ReadLine());
                        heli.Blades = bld;

                        //in case the helicopter is at the shelter
                        //everything set to zero and the details are displayed
                        Console.WriteLine("Is helicopter at hover? (y or n)");
                        string shelter = Console.ReadLine().ToUpper();

                        //checks whehter the helicopter is at hover 
                        bool flag;
                        if (shelter == "Y" || shelter == "YES")
                        {

                            flag = true;
                            if (flag == true)
                            {
                                //if yes then the hover function is called
                                heli.Hover();
                            }

                            //and the details are printed
                            Console.WriteLine(heli.ToString() + direction);
                            break;

                        }
                        //otherwise
                        else
                        {
                            //asking for the turns
                            Console.WriteLine("Please provide the (left/right) turn or quit");
                            turn = (Console.ReadLine()).ToUpper();

                            //prompting user again for turns till quit is entered
                            while (turn != "QUIT")
                            {
                                //in case the user enter the right turn it calls the TurnRight method form the parent class
                                if (turn == "RIGHT")
                                {
                                    heli.TurnRight();
                                }
                                //in case the user enter the left turn it calls the TurnLeft method form the parent class
                                else if (turn == "LEFT")
                                {
                                    heli.TurnLeft();
                                }

                                //asking again and again
                                Console.WriteLine("Please provide the (left/right) turn or quit");
                                turn = (Console.ReadLine()).ToUpper();
                            }

                            //asking the height for the flight
                            Console.WriteLine("Please provide the (up/down) height or quit");
                            height = (Console.ReadLine()).ToUpper();

                            //prompting user again for height till quit is entered
                            while (height != "QUIT")
                            {
                                //in case the user enter the up it calls the Climb method form the parent class
                                if (height == "UP")
                                {
                                    heli.Climb();
                                }
                                //in case the user enter the down it calls the Descend method form the parent class
                                else if (height == "DOWN")
                                {
                                    heli.Descend();
                                }

                                //asking again and again
                                Console.WriteLine("Please provide the (up/down) height or quit");
                                height = (Console.ReadLine()).ToUpper();
                            }
                            //Asking the user for how many times to increase the speed 
                            Console.WriteLine("How many time you want to increase your speed?");
                            speed_up = Convert.ToInt32(Console.ReadLine());

                            for (int i = 0; i < speed_up; i++)
                            {
                                heli.IncreaseAirspeed();
                            }

                            //Asking the user for how many times to decrease the speed 
                            Console.WriteLine("How many time you want to decrease your speed?");
                            speed_down = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < speed_down; i++)
                            {
                                heli.DecreasingAirspeed();
                            }
                        }

                        //printing the details of the aircraft with the direction
                        Console.WriteLine(heli.ToString() + direction);
                        break;


                    case 3:
                        //prompting user to enter the direction for heading
                        Console.WriteLine("Initialily Aircraft is heading towards?");
                        direction = (Console.ReadLine()).ToUpper();

                        //creating the new object for the GLIDER subclass
                        var gld = new Glider();

                        //asking for the turns
                        Console.WriteLine("Please provide the (left/right) turn or quit");
                        turn = (Console.ReadLine()).ToUpper();

                        //prompting user again for turns till quit is entered
                        while (turn != "QUIT")
                        {
                            //in case the user enter the right turn it calls the TurnRight method form the parent class
                            if (turn == "RIGHT")
                            {
                                gld.TurnRight();
                            }
                            //in case the user enter the left turn it calls the TurnLeft method form the parent class
                            else if (turn == "LEFT")
                            {
                                gld.TurnLeft();
                            }

                            //asking again and again
                            Console.WriteLine("Please provide the (left/right) turn or quit");
                            turn = (Console.ReadLine()).ToUpper();
                        }

                        //asking the height for the flight
                        Console.WriteLine("Please provide the (up/down) height or quit");
                        height = (Console.ReadLine()).ToUpper();

                        //prompting user again for height till quit is entered
                        while (height != "QUIT")
                        {
                            //in case the user enter the up it calls the Climb method form the parent class
                            if (height == "UP")
                            {
                                gld.Climb();
                            }
                            else if (height == "DOWN")
                            {
                                //in case the user enter the down it calls the Descend method form the parent class
                                gld.Descend();
                            }

                            //asking again and again
                            Console.WriteLine("Please provide the (up/down) height or quit");
                            height = (Console.ReadLine()).ToUpper();
                        }

                        //Asking the user for how many times to increase the speed 
                        Console.WriteLine("How many time you want to increase your speed?");
                        speed_up = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < speed_up; i++)
                        {
                            gld.IncreaseAirspeed();
                        }

                        //Asking the user for how many times to decrease the speed 
                        Console.WriteLine("How many time you want to decrease your speed?");
                        speed_down = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < speed_down; i++)
                        {
                            gld.DecreasingAirspeed();
                        }

                        //printing the details of the aircraft with the direction
                        Console.WriteLine(gld.ToString() + direction);
                        break;

                    //printing the values if the details are wrong
                    default:
                        Console.WriteLine("Check your inputs.");
                        break;
                }

                //RUNNNING THE PROGRAM AGAIN FOR THE DIFFERENT AIRCRAFT
                Console.WriteLine("\n\nPlease Choose your Aircraft Number\n" +
                    "1. Airplane\n" +
                    "2. Helicopter\n" +
                    "3. Glider\n" +
                    "4. Type 0 to exit and press enter(twice).");
                //again taking the input from the user
                air_vechile = Convert.ToInt32(Console.ReadLine());
            }

            //To make stable 
            Console.ReadLine();

        }
    }
}