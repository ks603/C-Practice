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
            string someText = "Here is some Text";
            string someOtherText = "Here is some text";

            bool isEqual = someText.Equals(someOtherText, StringComparison.OrdinalIgnoreCase);

            string addedText = someText + " " + someOtherText + " here is some more text.";
            string formattedString = string.Format("{0} {1} here is some more text.", someText, someOtherText);


            Console.WriteLine(formattedString);

            Console.WriteLine(someText.Length);
            Console.WriteLine(someText[3]);

            Console.WriteLine(someText.Substring(8, 4));

            Console.WriteLine(someText.ToUpper());

            Console.WriteLine(someOtherText.ToLower());

            string anotherText = string.Empty;

            string replacedText = someText.Replace("Text", "food");

            Console.WriteLine(replacedText);
        }
    }
}
