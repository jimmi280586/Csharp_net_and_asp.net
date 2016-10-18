using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataClasses
{
   public class Animal
   {
      public Animal()
      {
         Console.WriteLine("Animal constructor");
      }
      public void Greet()
      {
         Console.WriteLine("Animal says Hello");
      }
      public void Talk()
      {
         Console.WriteLine("Animal talk");
      }
      public virtual void Walk()
      {
         Console.WriteLine("Animal walk");
      }
      public virtual void Sing()
      {
         Console.WriteLine("Animal sing");
      }
   }
}
