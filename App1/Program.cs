using System;
using System.Collections;
public class FrisbeeLand
{
    public static void Main()
    {
        int n, i;
        String check;
        String[] names = new String[10];
        Queue q = new Queue();
        Console.Write("Enter how many people are in line ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the names of {0} people who are inline ", n);
        for (i = 0; i < n; i++)
        {
            names[i] = Console.ReadLine();
            q.Enqueue(names[i]);
        }
        while (true)
        {
            Console.WriteLine("\nEnter 'next' to enter more names in the queue");
            check = Console.ReadLine();
            if (check == "next")
            {
                String name;
                Console.WriteLine("Enter the name of new member");
                name = Console.ReadLine();
                q.Enqueue(name);
            }
            else
                break;
        }
        while (q.Count!=0)
        {
            Console.WriteLine("Enter 1 to pop out the person from the queue and put on the ride ");
            int m = Convert.ToInt32(Console.ReadLine());
            if (m == 1)
            {
                Console.WriteLine("Name of the person is:" + q.Dequeue());
            }
            else
                break;
        }
        Console.ReadLine();
    }

}
