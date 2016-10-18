using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataClasses
{
   public class Dog : Animal
   {
      public Dog()
      {
         Console.WriteLine("Dog constructor");
      }
      public new void Talk()
      {
         Console.WriteLine("Dog talk");
      }

      public override void Walk()
      {
         Console.WriteLine("Dog walk");
      }

      public override void Sing()
      {
         base.Sing();
         Console.WriteLine("Dog sing");
      }
   }
}
