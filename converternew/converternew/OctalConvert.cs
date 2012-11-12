using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converternew
{
    class OctalConvert: IConvertTo
    {
        public double ConvertTo(string numValue)
        {
            //Declaration
            double decNum = 0;

            if (numValue != null)
            {
                //Inline String to Array
                char[] ar = numValue.ToCharArray();
                //Reverse the array
                Array.Reverse(ar);
                //Write reversed array to the string
                numValue = new String(ar);
                //Go by every string's char
                for (int i = 0; i < numValue.Length; i++)
                {
                    //checked block begin
                    checked
                    {
                        try
                        {
                            decNum += double.Parse(numValue[i].ToString()) * Math.Pow(8, i);
                        }
                        catch
                        {
                            throw new ArgumentException(string.Format("Operation {0} is invalid", decNum), "decNum");
                        }
                    }
                    //checked block end
                }
            }

            return decNum;
        }

        public string ConvertFrom(Int64 numValue)
        {
            //Declaration
            Int64 binValue;
            char[] binArray;
            string binResult = "";
            //The binary number in reverse order
            while (numValue > 0)
            {
                binValue = numValue % 8;
                binResult += binValue;
                numValue = numValue / 8;
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
                    throw new ArgumentException(string.Format("Operation is invalid", binResult), "binResult");
                }
            }
            //checked block end
            return binResult;
        }
    }
}
