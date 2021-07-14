using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class InputConverter
    {
       public double ConvertInputToNumberic(string argTextInput)
        {
            double convertNumber;
            if (!double.TryParse(argTextInput, out convertNumber)) throw new ArgumentException("Expected A numeric value.");
            return convertNumber;
        }
    }
}
