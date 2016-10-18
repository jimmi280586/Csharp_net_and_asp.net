using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceExample
{
   interface IIntelligence
   {
      void PrintIQ();
   }

   public class Animal
   {
      public int Age { get; set; }
   }

   public class Mammal : Animal
   {
   }

   public class Person : Mammal, IIntelligence
   {
      public int Name { get; set; }
      public virtual void PrintIQ()
      {
         Console.WriteLine("IQ for person : normal");
      }
   }

   public class DNPI1Student : Person
   {
      public override void PrintIQ()
      {
         Console.WriteLine("IQ for DNPI1 student : above normal");
      }
   }


   class Program
   {
      static void Main(string[] args)
      {
         Person d1 = new Person();
         d1.PrintIQ();

         Person d2 = new DNPI1Student();
         d2.PrintIQ();


         Console.ReadKey();
      }
   }
}
