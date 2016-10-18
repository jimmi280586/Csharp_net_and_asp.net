using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataClasses;

namespace InheritanceExample
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("------------");
         Console.WriteLine("Testing Animal");
         Console.WriteLine("------------");
         Animal a1 = new Animal();
         a1.Greet();
         a1.Talk();
         a1.Walk();
         a1.Sing();

         Console.WriteLine("------------");
         Console.WriteLine("Testing dog");
         Console.WriteLine("------------");

         Animal d1 = new Dog();
         d1.Greet();
         d1.Talk();
         d1.Walk();
         d1.Sing();

         Console.WriteLine("------------");
         Console.WriteLine("Testing dog");
         Console.WriteLine("------------");
         Dog d2 = new Dog();
         d2.Greet();
         d2.Talk();
         d2.Walk();
         d2.Sing();

         Console.ReadKey();
      }
   }
}
