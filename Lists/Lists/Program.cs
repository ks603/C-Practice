using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "John";
            person.LastName = "Smith";

            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);



            ChangeName(person);
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
        }

        static void ChangeName(Person personToChange)
        {
            personToChange.FirstName = "Matt";
            personToChange.LastName = "Damon";
        }
    }
}
