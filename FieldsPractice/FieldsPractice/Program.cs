using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("SSN", "Data", "More Data");

            Console.WriteLine(person.HasProperDocuments);

        }
    }
}
