using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string someText = "Here is some text";
            string someOtherText = "Here is some other text";

            bool isEqual = someText.Equals(someOtherText, StringComparison.Ordinal);
        }
    }
}
