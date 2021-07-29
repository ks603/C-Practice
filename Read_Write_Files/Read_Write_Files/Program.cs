using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Read_Write_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = { "This is the first line", "This is the second line", "This is the third line" };
            File.WriteAllLines("MyFirstFile.txt", lines);

            string[] fileContents = File.ReadAllLines("MyFirstFile.txt");

            foreach(string line in File.ReadLines("MyFirstFile.txt"))
            {
                Console.WriteLine(line);
            }
        }
    }
}
