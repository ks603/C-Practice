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
            Person person1 = new Person("John", "Smith");

            person1.Sleep();

            SuperPerson person2 = new SuperPerson("John", "Doe");
            person2.Sleep();
            person2.Fly();

        }
    }
}
