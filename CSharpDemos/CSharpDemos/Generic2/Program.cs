using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic2
{
   class Program
   {
      static void Main(string[] args)
      {
         Stack<int> intStack = new Stack<int>();
         Stack<string> stringStack = new Stack<string>();

         
         PushMultiple( intStack, 42, 87, 112 );
         PushMultiple( stringStack, " hello world", " a ", " is ", "This" );


         Console.WriteLine( "Printing from int stack");
         foreach (var item in intStack )
         {
             Console.WriteLine( item );
         }

          Console.WriteLine("Printing from string stack");
         foreach (var item in stringStack)
         {
             Console.WriteLine(item);
         }

         Console.ReadKey();
      }
   
   
      static void PushMultiple<T>( Stack<T> stack, params T[] values )
      {
         foreach( T value in values )
         {
            stack.Push( value );
         }
      }

   }
}
