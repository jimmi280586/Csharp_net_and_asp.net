using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleFormatExamples
{
    struct st
    { 
        public int i;
    };

    class CL
    {
        public int i;
    };


   class Program
   {
      static void Main(string[] args)
      {
         int j = 12;
         Console.WriteLine(  "Hey here is J: {0} and {1}", j, j+j );

         Console.WriteLine("{0,10}", "Hello");
         Console.WriteLine("{0,-10}", "World");

         Console.Beep();
         Console.ForegroundColor = ConsoleColor.Yellow;

         #region Numeric Formatting
         // c (currency)
         Console.WriteLine(String.Format("c: {0:c}", 12345.67));

         // d (decimal)
         Console.WriteLine(String.Format("d: {0:d}", 12345));

         // e (exponential)
         Console.WriteLine(String.Format("e: {0:e}", 12345));

         // f (fixed point)
         Console.WriteLine(String.Format("f: {0:f}", 12345.67));

         // g (general) - Most compact decimal form
         Console.WriteLine(String.Format("g: {0:g}", 12345.67));

         // n (number)
         Console.WriteLine(String.Format("n: {0:n}", 12345.67));

         // x (hexadecimal)
         Console.WriteLine(String.Format("x: {0:x} {1:x} {2:x} {3:x} {4:x} {5:x}", 255, 254, 253, 252, 251, 250));
         #endregion

          Console.BackgroundColor = ConsoleColor.Cyan;

         #region Custom Format Strings
         // 0  - zero placeholder
         Console.WriteLine(String.Format("00#####.##: {0:00#####.##}", 12345.67));

         // #  - digit or space placeholder
         Console.WriteLine(String.Format("#####: {0:#####}", 12345.67));

         // ,    - display a comma
         Console.WriteLine(String.Format("##,###: {0:##,###}", 12345.67));

         // %   - display percentage
         Console.WriteLine(String.Format("%: {0:##%}", 12345.67));
         #endregion

         // Wait for CR
         Console.ReadLine();

      }
   }
}
