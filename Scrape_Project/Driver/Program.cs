using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project;


namespace Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrape scrape = new Scrape();
            var result = scrape.ScrapeWebpage("http://www.google.com");

            Console.WriteLine(result);
            
            Console.ReadKey();
        }
    }
}
