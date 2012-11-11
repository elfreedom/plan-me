using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converter
{
    class IHexal : IConvertTo
    {
        public double ConvertTo(string num_value)
        {
            const string TABLE = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            double rank = 1, result = 0;
            for (var i = num_value.Length - 1; i >= 0; i--)
            {
                var index = TABLE.IndexOf(num_value[i]);
                result += rank * index;
                rank *= 16;
            }
            return result;
        }

        public string ConvertFrom(int num_value)
        {
            var max_bit = 32;
            var dec_base = 10;
            var hexchars = new[] { 'A', 'B', 'C', 'D', 'E', 'F' };
            var result = string.Empty;
            var result_array = new int[32];

            for (/* nothing */; num_value > 0; num_value /= 16)
            {
                int i = num_value % 16;
                result_array[--max_bit] = i;
                //  Console.WriteLine(i.ToString());
            }

            for (int i = 0; i < result_array.Length; i++)
            {
                if (result_array[i] >= dec_base)
                {
                    result += hexchars[(int)result_array[i] % dec_base].ToString();
                }
                else
                {
                    result += result_array[i].ToString();
                }
            }

            result = result.TrimStart(new char[] { '0' });
            return result;
        }
    }
}
