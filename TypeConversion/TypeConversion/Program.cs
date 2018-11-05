using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int intuger = 7;
            float tooBig = 3.594792f;
            float superBig = 18746991231.12f;


//So, there are two types of type conversion (no pun intended) - Implicit and Explicit conversion.
//Implicit one is the one we don't really need to interviene with. Assuming there's no loss of information, compiler will do any
//such conversions like:

float flut = intuger; //since the integer is smaller than the float in terms of bytes, it can fit easily, therefore causing no errors.
            Console.WriteLine("Integer: {0} , and Float it's converted to: {1}", intuger, flut); // any similar scenarios will result in successful implicit conversion.


            //Now, if for some reason there was information loss during conversion, the conpiler has to warn us, because that information loss
            //might be critical - for instance financial data, scientific data ant etc. Example:

            //int iHaveNoTail = tooBig; //This won't compile because during conversion we lose decimal point information. It need's to be commented out.

            //To be able to convert this anyway, we can use Explicit conversion methods. If I understand well, explicit means that you have to manually
            //specify (confirm) that you're going to loose information during conversion. Example:

            int iHaveNoTail = (int)tooBig;  // this will compile, and it will trim float down so it would fit into integer: 123.45 f --> 123 int.
            Console.WriteLine("\nFloat: {0} , and Integer it's converted to: {1}", tooBig, iHaveNoTail);

            //The way I handled this explicit conversion was through typecast operator. However there is also Convert class option.
            //The difference between them is that in the case of overflow, typecast won't return the exception and will convert anyways:

            int overflow = (int)superBig; //overflow happens
            Console.WriteLine("\nFloat preconversion: {0}, Overflowed Interger: {1}", superBig, overflow);

            //If I had used Conversion class, the conversion wouldn't have happened, and I would have gotten an exception:

            int noConversion = Convert.ToInt32(superBig); //deliberately chose 32bit. This code doesn't need to be commented out, since it will crash on
            //the last line. So, all the other values will be visible.

            Console.ReadKey(); //maybe it's worth saying that strings always use explicit conversion, which I won't demonstrate here. I did it in my other tasks.
        }
    }
}
