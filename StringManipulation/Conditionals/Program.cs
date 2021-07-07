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
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            if (username.Equals("Kevin") && password.Equals("123456"))
            {
                Console.WriteLine("Hello Admin");
            }
            else if (username.Equals("Kevin"))
            {
                Console.WriteLine("Incorrect Password");
            }
            else if (password.Equals("123456"))
            {
                Console.WriteLine("Invalid Username");
            }
            else
            {
                Console.WriteLine("What Happened Here??");
            }

            switch (username)
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
