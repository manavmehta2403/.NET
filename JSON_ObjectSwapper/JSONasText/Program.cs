using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace JSONasText
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums1 = new List<int> { 2, 4, 6, 8, 10 };
            List<int> nums2 = new List<int> { 1, 3, 6, 9, 12};

            foreach (var item in nums1)
            {
                if (nums1.Any(x => nums2.Any(y => y == x)))
                {
                    Console.WriteLine("There are equal elements");
                }
                if (nums1.Any(x => !nums2.Any(y => y == x)))
                {
                    Console.WriteLine("No Match Found!");
                }
            }

                
            try
            {
                //READ ALL THE LINES FROM THE FILE
                IEnumerable<string> lines = File.ReadAllLines("Event_99.json");

                //LINE STARTS WITH
                string input = $"\"_ts\"";

                //INDENTIFY THE MATCHES WITH LINQ WHERE AND TRIM THE SPACES AND CHECKING THE START WITH ELEMENT
                IEnumerable<string> matches = !String.IsNullOrEmpty(input)
                                            ? lines.Where(line => line.Trim().StartsWith(input))
                                            : Enumerable.Empty<string>();
                
                //The newlines Enumerable is for the new lines
                IEnumerable<string> newLines = new List<string>();
                //The oldlines Enumerable is for the not to change lines
                IEnumerable<string> oldlines = lines.Except(matches);
                
                /*
                    Stuck point was the the substring REMEMBER it does not take the last index it takes the int 
                    as second argument for number of character you want to print after that.
                */
                foreach (var l in matches)
                {
                    //the last index for the first number can be caluculated 
                    //int last_index = (l.IndexOf(',')-1) - l.IndexOf('(');
                    string num1 = l.Substring(l.IndexOf('(') + 1, (l.IndexOf(',') - 1) - l.IndexOf('('));
                    string num2 = l.Substring(l.IndexOf(',') + 2, (l.IndexOf(')') - 2) - l.IndexOf(','));
                    System.Console.WriteLine($"{num1} \t {num2}");
                    newLines = matches.Select(s => s.Replace(num1, "ⁿ").Replace(num2, num1).Replace("ⁿ", num2)).ToList();

                }
                newLines.ToList().ForEach(Console.WriteLine);
                oldlines.ToList().ForEach(Console.WriteLine);
            }
            catch (System.Exception e)
            {

                System.Console.WriteLine(e.Message); ;
            }

            // Console.ReadKey();
        }
    }
}
