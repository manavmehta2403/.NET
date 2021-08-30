using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseHold
{
    //Creating the class HouseHoldCensus
    class HouseholdCensus
    {
        //Declaring the private variable arrays all of the size of 10
        private string[] households_head = new string[10];
        private double[] households_income = new double[10];
        private int[] households_members = new int[10];
        private char[] assistance = new char[10];

        //counter variable of data type int
        private int counter;

        //constructor that assigns the counter varaible value 0
        public HouseholdCensus()
        {
            this.counter = 0;
        }

        //Method to take user input for the array
        public void inputHouseoldInfo()
        {
            //variable for user to ask whether they want to enter more families or not
            char choice = 'Y';
           

            /*
             * Please keep the input in the array range, so input max to max 10 values
             */

            //loop to enter the user value
            while (choice != 'n' || choice != 'N') //loop exits when user enters the "n" as the choice
            {
                //Prompting usser to enter the head name of the family
                Console.WriteLine("Please enter the house hold head name of the family - {0}: ", counter+1);
                households_head[counter] = Console.ReadLine();

                //Prompting user to enter the income of the family
                Console.WriteLine("Please enter the house hold income of the family - {0}: ", counter+1);
                households_income[counter] = Convert.ToDouble(Console.ReadLine());

                //Prompting user to enter the members of the family
                Console.WriteLine("Please enter the house hold member of the family - {0}: ", counter+1);
                households_members[counter] = Convert.ToInt32(Console.ReadLine());

                //increasing the counter by 1
                counter = counter + 1;

                //Asking the user if they want to enter more values
                Console.WriteLine("Do you have more households to enter?(y/n)");
                choice = Convert.ToChar(Console.ReadLine());
                if (choice == 'N' || choice == 'n')
                {
                    break;
                }
                continue;
            } 
        }

        //Method to find the assistance 
        public void determineAssistance()
        {

            /*
             * Household Size* Maximum Income Level (Per Year)
                1               $16,000
                2               $22,000
                3               $28,000
                4               $33,000
                5               $34,000
                6               $45,000
                7               $50,000
                8               $55,000
             *Increment of 500 if more than 8
             */

            //looping from 0 to counter to check the 
            for (int i = 0; i <= counter; i++)
            {
                //checks if the number of member is 1 and their salary is less than 16000
                if (households_members[i] == 1 && households_income[i] < 16000)
                {
                    assistance[i] = 'Y';
                }
                //checks if the number of member is 2 and their salary is less than 22000
                else if (households_members[i] == 2 && households_income[i] < 22000)
                {
                    assistance[i] = 'Y';
                }
                //checks if the number of member is 3 and their salary is less than 28000
                else if (households_members[i] == 3 && households_income[i] < 28000)
                {
                    assistance[i] = 'Y';
                }
                //checks if the number of member is 4 and their salary is less than 33000
                else if (households_members[i] == 4 && households_income[i] < 33000)
                {
                    assistance[i] = 'Y';
                }
                //checks if the number of member is 5 and their salary is less than 334000
                else if (households_members[i] == 5 && households_income[i] < 34000)
                {
                    assistance[i] = 'Y';
                }
                //checks if the number of member is 6 and their salary is less than 45000
                else if (households_members[i] == 6 && households_income[i] < 45000)
                {
                    assistance[i] = 'Y';
                }
                //checks if the number of member is 7 and their salary is less than 50000
                else if (households_members[i] == 7 && households_income[i] < 50000)
                {
                    assistance[i] = 'Y';
                }
                //checks if the number of member is 8 and their salary is less than 55000
                else if (households_members[i] == 8 && households_income[i] < 55000)
                {
                    assistance[i] = 'Y';
                }
                //checks if the number of member is 9 and their salary is less than 60000
                else if (households_members[i] == 9 && households_income[i] < 60000)
                {
                    assistance[i] = 'Y';
                }
                //checks if the number of member is 4 and their salary is less than 65000
                else if (households_members[i] == 10 && households_income[i] < 65000)
                {
                    assistance[i] = 'Y';
                }

                else
                {
                    assistance[i] = 'N';
                }

            }
        }

        //display the information taking four array as the parameters and the counter
        public void displayHouseholdInfo()
        {

            //Displaying the headers
            Console.WriteLine("Number Of\nHouseHold Name\tAnnual Income\tHouseHold Members\tAssistance?");

            //loop to print parallel arrays
            //iterating over the rows
            for (int c = 0; c < counter; c++)
            {
                //iterating over the columns
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", households_head[c], households_income[c], households_members[c], assistance[c]);
                
            }

            //Printing average income using inbuilt function called Average()
            Console.WriteLine("AVERAGE INCOME\t{0}", households_income.Average());
        }

    }
    public class Program
    {
        public static void Main(string[] args)
        {
            HouseholdCensus h = new HouseholdCensus();
            h.inputHouseoldInfo();
            h.determineAssistance();
            h.displayHouseholdInfo();

            Console.ReadLine();
        }
    }
}
