using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParameterExample
{
   class Program
   {
      static void Main(string[] args)
      {
         int a = 10;

         int result = AddOne(a);
         Console.WriteLine("a={0} result={1}", a, result);

         result = AddOne(ref a);
         Console.WriteLine("a={0} result={1}", a, result);

         AssignTwo(out a);
         Console.WriteLine("a={0} ", a);


         Console.ReadKey();
      }

      #region ref
      static int AddOne(int a)
      {
         a = a + 1;
         return a;
      }
      static int AddOne(ref int a)
      {
         a = a + 1;
         return a;
      }
      #endregion

      #region out
      static void AssignTwo(out int a)
      {
         a = 2;
      }

      #endregion
   }
}
