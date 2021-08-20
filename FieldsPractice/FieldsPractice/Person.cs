using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsPractice
{
    class Person
    {
        string _ssn;
        string _passportData;
        string _driversLicesneNumber;

        public Person(string ssn, string passportData, string driversLicesneNumber)
        {
            _ssn = ssn;
            _passportData = passportData;
            _driversLicesneNumber = driversLicesneNumber;
        }
        public bool HasProperDocuments
        {
            get
            {
                return _ssn.Length > 0 && _passportData.Length > 0 && _driversLicesneNumber.Length > 0;
            }
        }
         
    }
}
