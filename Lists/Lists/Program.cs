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
            List<int> list = new List<int>() { 1, 5, 7, 9, 10 };
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }

            for (int i = 0; i <= list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
