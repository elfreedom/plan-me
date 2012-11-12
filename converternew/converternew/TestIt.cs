using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converternew
{
    class Program
    {
        static void Main()
        {
            string binNum = "1010";
            int decNum = 10;

            BinaryConvert BnC;
            BnC = new BinaryConvert();

            Console.WriteLine("Binary {0} in dec is {1}", binNum, BnC.ConvertTo(binNum));
            Console.WriteLine("Decimal {0} in binary is {1}", decNum, BnC.ConvertFrom(decNum));
            Console.ReadLine();


            binNum = "12";
            decNum = 10;

            OctalConvert OctC;
            OctC = new OctalConvert();
            
            Console.WriteLine("Octal {0} in dec is {1}", binNum, OctC.ConvertTo(binNum));
            Console.WriteLine("Decimal {0} in Octal is {1}", decNum, OctC.ConvertFrom(decNum));
            Console.ReadLine();

            HexalConvert HexC;
            HexC = new HexalConvert();

            binNum = "A";
            decNum = 10;

            Console.WriteLine("Hexal {0} in dec is {1}", binNum, HexC.ConvertTo(binNum));
            Console.WriteLine("Decimal {0} in Hexal is {1}", decNum, HexC.ConvertFrom(decNum));
            Console.ReadLine();

        }
    }

}
