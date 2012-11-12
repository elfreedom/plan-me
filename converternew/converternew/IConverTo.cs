using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converternew
{
    public interface IConvertTo
    {
        //From any to Decimal
        double ConvertTo(string numValue);
        //From Decimal to any
        string ConvertFrom(Int64 numValue);
    }
}
