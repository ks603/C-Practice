using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserved_Words
{
    class Program
    {
        public const string someText = "This is text";

        public readonly string someOtherText = "This is some other text";
        static void Main(string[] args)
        {
            Console.WriteLine(someOtherText);
        }
    }
}
