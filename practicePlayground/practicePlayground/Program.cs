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

            Person newPerson = person ?? new Person("Default", "Person");

            Console.WriteLine(newPerson.FirstName);
            Console.WriteLine(newPerson.LastName);
        }
    }
}
