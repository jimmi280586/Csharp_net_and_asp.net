using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateExample
{
   class MathLib
   {
      public void Add(int i, int j)
      {
         Console.WriteLine("{0} + {1} = {2}", i, j, i + j);
      }

      #region more
      public void Sub(int i, int j)
      {
         Console.WriteLine("{0} - {1} = {2}", i, j, i - j);
      }

      public void Multiply(int i, int j)
      {
         Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
      }
      #endregion
   }

   class Program
   {
      public delegate void MathOperation(int i, int j);

      static void Main()
      {
         MathLib math = new MathLib();

         MathOperation f = new MathOperation(math.Add);
         f(7, 5);

         f = math.Sub;
         f( 7, 5 );

         #region more
         //f = new MathOperation(math.Sub);
         //f(7, 5);

         //f = new MathOperation(math.Multiply);
         //f(7, 5);
         #endregion

         #region multicast
         //MathOperation f = new MathOperation(math.Add);
         f += new MathOperation(math.Sub);
         f += new MathOperation(math.Multiply);
         f(7, 5);

         //f += math.Add;

         #endregion


         #region lambda
         MathOperation MO = (x, y) => Console.WriteLine(x + y);
         MO(10, 10);
         #endregion


         // Wait for CR
         Console.ReadLine();
      }
   }
}
