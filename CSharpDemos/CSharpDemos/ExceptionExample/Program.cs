using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionExample
{
   class Program
   {
      static void Main(string[] args)
      {
         try
         {
            Console.WriteLine("Enter a number: ");
            int i = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            int j = int.Parse(Console.ReadLine());

            int k = i / j;

            Console.WriteLine("{0} divided with {1} equals {2}", i, j, k);
         }
         catch (OverflowException caught)
         {
            Console.WriteLine(caught);
         }
         catch (DivideByZeroException caught)
         {
            Console.WriteLine(caught);
            // throw new ArithmeticException( "Entered number gave an error", caught );
         }
         catch( Exception e )
         {

         }
         finally
         {
            Console.WriteLine("\r\nFinally always reached");
         }


			// Wait for CR
			Console.ReadLine();
      }
   }
}
