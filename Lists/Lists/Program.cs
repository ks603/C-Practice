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
            //var input = Console.ReadLine();
            //Console.WriteLine("User input is {0}", input);

            //while (!input.Equals(string.Empty))
            //{
            //    input = Console.ReadLine();
            //    Console.WriteLine("User input is {0}", input);
            //}

            var input = string.Empty;

            do
            {
                input = Console.ReadLine();
                Console.WriteLine("User input is {0}", input);

            } while (!input.Equals(string.Empty));
        }
    }
}
