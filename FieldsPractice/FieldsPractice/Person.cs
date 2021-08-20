using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsPractice
{
    class Person
    {
        string _ssn = "SSN";
        string _passportData = "Data";
        string _driversLicesneNumber = "More Data";
        string _firstName = "Tim";
        string _lastName = "Ranch";

        public bool HasProperDocuments
        {
            get
            {
                return _ssn.Length > 0 && _passportData.Length > 0 && _driversLicesneNumber.Length > 0;
            }
        }

        public string FirstName {
            get
            {
                return _firstName;
            }
            set
            {
                if (value.Length < 1)
                {
                    Console.WriteLine("Input is not accepted");
                    return;
                }
                _firstName = value;
            }
        }
        public string LastName {
            get
            {
                return _lastName;
            }
            set
            {
                if (value.Length < 1)
                {
                    Console.WriteLine("Input is not accepted");
                    return;
                }
                _lastName = value;
            }
        }
    }
}
