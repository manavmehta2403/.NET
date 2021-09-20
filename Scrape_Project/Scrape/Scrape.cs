using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Scrape
    {
        public string ScrapeWebpage(string url)
        {
            return Readurl(url);
        }
        public string ScrapeWebpage(string url, string filepath)
        {
            string reply = Readurl(url);
            File.WriteAllText(filepath, reply);

            return reply;
        }
        public string Readurl(string url)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString(url);
            return reply;
        }
    }
}
