using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converternew
{
    class HexalConvert:IConvertTo
    {
        public double ConvertTo(string numValue)
        {
            //Declaration
            const string hexChars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            double rank = 1, decNum = 0;

             if (numValue != null)
              {
                  for (int i = 0; i < numValue.Length; i++)
                  {
                      var index = hexChars.IndexOf(numValue[i]);
                      decNum += rank * index;
                      rank *= 16;
                  }
              }
            return decNum;
        }

        public string ConvertFrom(Int64 numValue)
        {
            //Declaration
            Int64 binValue;
            char[] binArray;
            string binResult = string.Empty;
            var hexchars = new[] { 'A', 'B', 'C', 'D', 'E', 'F' };
            //The binary number in reverse order
            while (numValue > 0)
            {
                binValue = numValue % 16;
                if (binValue >= 10)
                {
                    binResult += hexchars[binValue % 10];
                }
                else
                {
                    binResult += binValue;
                }        
                
                numValue = numValue / 16;
            }

            //Put it in an array and reverse
            //checked block begin
            checked
            {
                try
                {
                    binArray = binResult.ToCharArray();
                    Array.Reverse(binArray);
                    binResult = new string(binArray);
                }
                catch
                {
                    throw new ArgumentException(string.Format("Operation {0} is invalid", binResult), "binResult");
                }
            }
            //checked block end
            return binResult;
        }
    }
}
