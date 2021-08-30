using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Generic
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] array = new int[] { 00, 01, 02, 03, 04, 05, 06, 07, 08, 09 };

            foreach (int elements in array)
            {
                Console.WriteLine(elements);
            }

            Console.WriteLine();



            // Creates and initializes a new ArrayList.
            ArrayList AL = new ArrayList();
            AL.Add(0);
            AL.Add(1);
            AL.Add(2);
            AL.Add(3);
            foreach (Object obj in AL)
            {
                Console.WriteLine($"{obj}");
            }

            AL.Remove(1);
            Console.WriteLine($"Cannot pass remove for ArrayList");
            foreach (Object obj in AL)
            {
                Console.WriteLine($"{obj}");
            }

            Console.WriteLine();




            List<int> list = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            foreach (int elements in list)
            {
                Console.WriteLine(elements);
            }

            Console.WriteLine($"{list.Remove(1)}");

            Console.WriteLine();


            // Create a new hash table.
            Hashtable hashdict = new Hashtable();

            // Add some elements to the hash table. There are no
            // duplicate keys, but some of the values are duplicates.
            hashdict.Add("a", 1);
            hashdict.Add("b", 2);
            hashdict.Add("c", 3);
            hashdict.Add("d", 4);
            foreach (DictionaryEntry hd in hashdict)
            {
                Console.WriteLine($"Key = {hd.Key}, Value = {hd.Value}");
            }

                // To get the values alone, use the Values property.
                ICollection valueColl = hashdict.Values;

            // The elements of the ValueCollection are strongly typed
            // with the type that was specified for hash table values.
            Console.WriteLine();
            foreach (int values in valueColl)
            {
                Console.WriteLine($"Value = {values}");
            }

            // To get the keys alone, use the Keys property.
            ICollection keyColl = hashdict.Keys;

            // The elements of the KeyCollection are strongly typed
            // with the type that was specified for hash table keys.
            Console.WriteLine();
            foreach (string keys in keyColl)
            {
                Console.WriteLine($"Key = {keys}");
            }

            hashdict.Remove("d");
            Console.WriteLine($"Cannot pass remove for hashtable");
            foreach (DictionaryEntry hd in hashdict)
            {
                Console.WriteLine($"Key = {hd.Key}, Value = {hd.Value}");
            }

            Console.WriteLine();




            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("a", 1);
            dict.Add("b", 2);
            dict.Add("c", 3);
            dict.Add("d", 4);
            // When you use foreach to enumerate dictionary elements,
            // the elements are retrieved as KeyValuePair objects.
            foreach (KeyValuePair<string, int> kvp in dict)
            {
                Console.WriteLine($"Key = {kvp.Key}, Value = {kvp.Value}");
            }

            // To get the values alone, use the Values property.
            Dictionary<string, int>.ValueCollection valueCol = dict.Values;

            // The elements of the ValueCollection are strongly typed
            // with the type that was specified for dictionary values.
            Console.WriteLine();
            foreach (int values in valueCol)
            {
                Console.WriteLine($"Value = {values}");
            }

            // To get the keys alone, use the Keys property.
            Dictionary<string, int>.KeyCollection keyCol = dict.Keys;

            // The elements of the KeyCollection are strongly typed
            // with the type that was specified for dictionary keys.
            Console.WriteLine();
            foreach (string keys in keyCol)
            {
                Console.WriteLine($"Key = {keys}");
            }

            Console.WriteLine($"{dict.Remove("a")}");

            Console.WriteLine();




            // Creates and initializes a new Queue.
            Queue que = new Queue();
            que.Enqueue(0);
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            foreach (Object obj in que)
            {
                Console.WriteLine($"{obj}");
            }

            Console.WriteLine();




            Queue<string> numb = new Queue<string>();
            numb.Enqueue("zero");
            numb.Enqueue("one");
            numb.Enqueue("two");
            numb.Enqueue("three");


            // A queue can be enumerated without disturbing its contents.
            foreach (string number in numb)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine($"\nDequeuing '{numb.Dequeue()}'");

            Console.WriteLine();




            // Creates and initializes a new Queue.
            Stack stk = new Stack();
            stk.Push(0);
            stk.Push(1);
            stk.Push(2);
            stk.Push(3);
            foreach (Object obj in stk)
            {
                Console.WriteLine($"{obj}");
            }

            Console.WriteLine();




            Stack<string> num = new Stack<string>();
            num.Push("zero");
            num.Push("one");
            num.Push("two");
            num.Push("three");


            // A queue can be enumerated without disturbing its contents.
            foreach (string number in num)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine($"\nPoping '{num.Pop()}'");











            Console.ReadKey();

        }
    }
}
