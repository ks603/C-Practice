using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebScraper
{
    class Program
    {
        private const string Method = "search";
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter which city you would like to scrape information from:");
            var craigsListCity = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Please enter the Craiglist category that you would like to scrape");
            var craigslistCategoryName = Console.ReadLine() ?? string.Empty;

            using (WebClient client = new WebClient())
            {
                string content = client.DownloadString($"http://{craigsListCity.Replace(" ", string.Empty)}craigsListCity.org/{Method}/{craigslistCategoryName}");
            }
        }
    }
}
