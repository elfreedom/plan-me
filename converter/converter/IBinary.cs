using System;
using System.Text;


namespace converter
{
    public class IBinary : IConvertTo
    {
        public double ConvertTo(string num_value)
        {
            double dec_num = 0; //Converted number

            char[] ar = num_value.ToCharArray(); //Inline String to Array
            Array.Reverse(ar); //Reverse the array
            num_value = new String(ar); //Write reversed array to the string

            for (int i = 0; i < num_value.Length; i++) //Go by every string's char
            {
                dec_num += double.Parse(num_value[i].ToString()) * Math.Pow(2, i); //pow every char on 2 in thats case(case = position)
            }

            return dec_num; //our dec number
        }

       public  string ConvertFrom(int num_value)
        {
            var result = string.Empty;
            var result_array = new int[32];
            var max_bit = 32;
            for (/* nothing */; num_value > 0; num_value /= 2)
            {
                int i = num_value % 2;
                result_array[--max_bit] = i;
            }

            for (int i = 0; i < result_array.Length; i++)
            {
                    result += result_array[i].ToString();
            }

            result = result.TrimStart(new char[] { '0' });
            return result;
        }


    }

}
