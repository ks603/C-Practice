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
            int[] array = { 1, 5, 7, 8, 10 };

            foreach (var element in array)
            {
                Console.WriteLine(element + 1);
            }
            Console.WriteLine(array);
        }
    }
}
