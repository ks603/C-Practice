using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var myFirstList = new List<int>();

            Console.WriteLine(myFirstList.Count());

            myFirstList.Add(10);
            myFirstList.Add(5);

            Console.WriteLine(myFirstList);
        }
    }
}
