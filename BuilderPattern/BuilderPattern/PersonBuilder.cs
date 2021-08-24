using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class PersonBuilder
    {

        private string _firstName;
        private string _lastName;
        private int _age;
        private int _eyeColor;
        private int _hairColor;

        public PersonBuilder()
        {
            SetDefaults();
        }

        private void SetDefaults()
        {
            _firstName = "John";
            _lastName = "Smiht";
            _age = 30;
            _eyeColor = 153;
            _hairColor = 153;
        }

        public PersonBuilder WithFirstName(string firstName)
        {
            _firstName = firstName;
            return this;
        }
        public PersonBuilder WithLastName(string lastName)
        {
            _lastName = lastName;
            return this;
        }

        public PersonBuilder withAge(int age)
        {
            _age = age;
            return this;
        }

        public PersonBuilder WithEyeColor(int eyeColor)
        {
            _eyeColor = eyeColor;
            return this;
        }

        public PersonBuilder withHairColor(int hairColor)
        {
            _hairColor = hairColor;
            return this;
        }

        public Person Build()
        {
            Person person = new Person(_firstName, _lastName, _age, _eyeColor, _hairColor);
            return person;
        }



        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public int Age { get; set; }
        //public int EyeColor { get; set; }
        //public int HairColor { get; set; }
    }
}
