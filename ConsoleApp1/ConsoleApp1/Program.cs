using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();

                int convertedNumber;
                bool isConvertedSuccesfully = int.TryParse(input, out convertedNumber);

                if (!isConvertedSuccesfully)
                {
                    throw new Exception("Conversion was not succesful.");
                }
            } catch (Exception ex)
            {
                Console.WriteLine("There was an error: {0}", ex.Message);
            }
            Console.WriteLine("The rest of my application is still running");
        }
    }
}
