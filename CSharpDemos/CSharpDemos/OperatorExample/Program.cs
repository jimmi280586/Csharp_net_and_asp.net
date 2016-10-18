using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperatorExample
{
   class Program
   {
      static void Main(string[] args)
      {
         Time time1 = new Time(2, 10);
         Time time2 = new Time(10);
         Time time3 = time1 + time2;

         Console.WriteLine("Time is {0}", time3);

         time3++;
         Console.WriteLine("Time is {0}", time3);

         time3 = time1 - time2;
         Console.WriteLine("Time is {0}", time3);

         // Explicit conversion from int
         time3 = (Time)12;
         Console.WriteLine("Time is {0}", time3);

         // Explicit conversion from float
         time3 = (Time)12.22;
         Console.WriteLine("Time is {0}", time3);

         // Implicit conversion
         int tMinutes = time3;
         Console.WriteLine("tMinutes is {0}", tMinutes);



         Console.ReadKey();
      }
   }
}
