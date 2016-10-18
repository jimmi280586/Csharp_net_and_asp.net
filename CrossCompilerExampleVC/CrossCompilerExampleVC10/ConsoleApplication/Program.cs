using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VIA;

namespace ConsoleApplication
{
   class Program
   {
      static void Main(string[] args)
      {
         DNP1MathLib mathLib = new VIA.DNP1MathLib();

    

         Console.WriteLine("Test add  3 + 2 = {0}  Test sub", mathLib.Add(3, 2));
         Console.WriteLine("Test sub  3 - 2 = {0}", mathLib.Sub(3, 2));
         Console.WriteLine("Test mul  3 * 2 = {0}", mathLib.Mul(3, 2));
         Console.ReadKey();
      }
   }
}
