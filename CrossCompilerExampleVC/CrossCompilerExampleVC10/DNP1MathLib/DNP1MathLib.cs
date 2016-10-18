using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VIA
{
   public class DNP1MathLib
   {
      public int Add(int a, int b) 
      { 
         return a + b; 
      }
      
      public int Sub(int a, int b) 
      { 
         return a - b; 
      }
      
      public int Mul(int a, int b) 
      { 
         return a * b; 
      }

      public int Div(int a, int b)
      {
         if (b == 0)
         {
            throw new DivideByZeroException("Please do NOT divide by zero");
         }
         else
            return a / b;
      }
   }
}
