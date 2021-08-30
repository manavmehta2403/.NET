using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverser
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine($"{String.Join("", ReverserChar("Hello Manav Bro"))}");
            /*
             * Printer cannot work with Char
            */ 
            //Console.WriteLine($"{String.Join(" ", ReverserStr("Hello Manav Bro"))}");
            Printer(Sorter(ReverserStr("Hello Manav Bro")));


            Console.ReadKey();
        }

        static char[] ReverserChar(string str)
        {
            char[] charArray = str.ToCharArray();

            Array.Reverse(charArray);

            return charArray;

        }

        static string[] ReverserStr(string str)
        {
            string[] strArray = str.Split(new char[] { ' ' });

            Array.Reverse(strArray);

            return strArray;
        }
        static void Printer(Object[] var)
        {
            foreach (Object v in var )
            {
                Console.Write(v+" ");
            }
        }
        static Object[] Sorter(Object[] var)
        {
            Array.Sort(var);
            return var;
        }







        //
public static int CountVowels(string str) 
    {
            char[] array = str.ToCharArray();
			int count = array.Count(x => x =='a' || x =='i' || x== 'e' || x== 'o'|| x=='u');
			return count;
    }

    public static bool SameCase(string str)
    {
			if (str.All(char.IsUpper) || str.All(char.IsLower))
			{
				return true;
			}
			else
			{
				return false;
			}
    }

    }
}
