using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicePlayground
{
    class Person
    {
        public Person(string argFirstname, string argLastName)
        {
            FirstName = argFirstname;
            LastName = argLastName;
        }

        public string FirstName { get; }
        public string LastName { get; }
    }
}
