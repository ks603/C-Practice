﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsPractice
{
    class SuperPerson : Person
    {
        public SuperPerson(string FirstName, string LastName) :
            base(FirstName, LastName)
        {

        }
        
        public void Fly()
        {
            Console.WriteLine("I am flying {0} {1}", FirstName, LastName);

        }
    }
}
