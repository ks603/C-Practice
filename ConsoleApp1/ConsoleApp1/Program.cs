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

                try
                {
                    StringToIntConverter stringToIntConverter = new StringToIntConverter();
                    StringToIntConverter.convert(input);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("There was an error with converions: {0}", ex.Message);

            } catch (Exception ex)
            {
                Console.WriteLine("There was an error: {0}", ex.Message);
            } finally
            {
                Console.WriteLine("The rest of my application is still running.");
            }
            
        }
    }
}
