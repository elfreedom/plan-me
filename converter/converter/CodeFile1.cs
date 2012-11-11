using System;

namespace converter
{
    class Program
    {
         static void Main(string[] args)
        {
           IBinary bn; 
           bn = new IBinary();
           IOctal oc;
           oc = new IOctal();
           IHexal hx;
           hx = new IHexal();
           
           int dec = 10;
           Console.WriteLine("{0} in binary is {1}", dec, bn.ConvertFrom(dec));
           Console.WriteLine("{0} in ocatal is {1}", dec, oc.ConvertFrom(dec));
           Console.WriteLine("{0} in hexal is {1}", dec, hx.ConvertFrom(dec));

           string hexi = "A";
           Console.WriteLine("{0} in dec is {1}", hexi, hx.ConvertTo(hexi));
           string octi = "12";
           Console.WriteLine("{0} in dec is {1}", octi, oc.ConvertTo(octi));
           string bini = "1010";
           Console.WriteLine("{0} in dec is {1}", bini, bn.ConvertTo(bini));
        //   Console.WriteLine("{0} in dec is {1}", hexi, bn.ConvertTo(hexi));
         //  Console.WriteLine("{0} in dec is {1}", dec, oc.ConvertFrom(dec));
         //  Console.WriteLine("{0} in dec is {1}", dec, hx.ConvertFrom(dec));


       
           Console.ReadLine();
        }
    }
}