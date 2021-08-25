using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpCalculator simpleCalculator1 = new SimpCalculator();

            var scenario1 = true;
            if (scenario1)
            {
                Console.Write("Answer is {0}", simpleCalculator1.Add(3, 4));
            }
            else
            {
                Console.WriteLine(simpleCalculator1.Add(1, 2));
            }
        }
    }
}
