using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Equals("Kevin"))
            {
                Console.WriteLine("Hello Admin");
            }
            else if (input.Equals("Joe"))
            {
                Console.WriteLine("Hi Joe");
            }
            else
            {
                Console.WriteLine("Who you?");
            }

            switch (input)
            {
                case "Matt":
                    Console.WriteLine("Hello Admin");
                    break;
                case "Chris":
                    Console.WriteLine("Hello Admin");
                    break;
                case "Dan":
                    Console.WriteLine("Hello Admin");
                    break;
                default:
                    Console.WriteLine("Hello Guest");
                    break;
            }
        }
    }
}
