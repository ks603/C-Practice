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

        public bool HasProperDocuments
        {
            get
            {
                return _ssn.Length > 0 && _passportData.Length > 0 && _driversLicesneNumber.Length > 0;
            }
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
