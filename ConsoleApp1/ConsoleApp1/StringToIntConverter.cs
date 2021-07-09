using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StringToIntConverter
    {
        public int convert(string input)
        {
            try 
            {
                int convertedNumber;
                bool isConvertedSuccesfully = int.TryParse(input, out convertedNumber);

                if (!isConvertedSuccesfully)
                {
                    throw new Exception("Conversion was not succesful.");
                }

                return convertedNumber;
            }
            catch (Exception ex)
            {
                throw new Exception("new Message", ex);
            }
        }
    }
}
