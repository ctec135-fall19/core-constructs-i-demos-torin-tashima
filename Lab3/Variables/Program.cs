using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            #region variable declarations, page 68
            int myInt;
            long myLong = 0;
            double myDouble = 0.0;
            string myStr = "Miles the Car";
            #endregion

            #region printing, page 63-67
            // build errors and warnings
            //Console.WriteLine("myInt: {0}", myInt);

            Console.WriteLine("myLong: {0}", myLong);
            Console.WriteLine("myLong c: {0:c}", myLong);  // 0:c means currency
            Console.WriteLine("myLong d: {0:d}", myLong);
            Console.WriteLine("myLong d: {0:d6}", myLong);
            Console.WriteLine("myLong x: {0:x}", 31);  // 0:x means hexadecimal
            Console.WriteLine();
            #endregion

            #region casting, page 88-90
            byte myByte = 255;
            byte myByte2 = (byte)(myByte + 1);
            Console.WriteLine("myByte: {0} + 1 = {1}", myByte, myByte2);  // 255 + 1 = 0 ?!?!
            Console.WriteLine();
            #endregion

            #region strings, page 79-88
            string hello = "hello";
            string world = "world";
            string str;

            Console.WriteLine("length of hello: {0}", hello.Length);
            Console.WriteLine("test ==: {0}", hello == "hello2");  // False
            Console.WriteLine("test ==: {0}", hello == "hello");  // True
            Console.WriteLine("test ==: {0}", hello.Equals("Hello"));  // False - case sensitivity

            Console.WriteLine("compare: {0}", hello.CompareTo(world));
            Console.WriteLine("compare: {0}", hello.CompareTo(hello));
            Console.WriteLine();

            // concatenation
            str = hello + " " + world;
            Console.WriteLine(str);
            Console.WriteLine();

            // verbatim
            str = @"c:\MyApp\bin\debug";  // @ sign ignores escape characters
            string str2 = "c:\\MyApp\\bin\\debug";  // escape characters needed here

            Console.WriteLine(str);
            Console.WriteLine(str2);
            Console.WriteLine();
            #endregion
        }
    }
}
