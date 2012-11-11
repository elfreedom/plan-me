using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converter
{
    interface IConvertTo
    {
        double ConvertTo(string num_value);//to dec
        string ConvertFrom(int num_value); //dec to 
    }

}
