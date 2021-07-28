using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicePlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John", "Smith");

            Console.WriteLine(person.FirstName);
        }
    }
}
