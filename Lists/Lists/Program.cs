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

            for(int i=0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            int index = 0;
            while (index < array.Length)
            {
                Console.WriteLine(array[index]);
                index++;
            }
        }
    }
}
