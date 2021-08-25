using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class SimpCalculator
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Subract(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        public void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
    }
}
