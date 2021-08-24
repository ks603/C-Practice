using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new PersonBuilder().Build();

            Person person2 = new PersonBuilder().withAge(35).Build();

            Person person3 = new PersonBuilder().withAge(39).Build();

            Console.WriteLine(person1);
        }
    }
}
