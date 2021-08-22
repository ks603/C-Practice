using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UsingKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebClient client = new WebClient())
            {
                string googleMainPage = client.DownloadString("http://www.Google.com");
                Console.WriteLine(googleMainPage);
            }
        }
    }
}
