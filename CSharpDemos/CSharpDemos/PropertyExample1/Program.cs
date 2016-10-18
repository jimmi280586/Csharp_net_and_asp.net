using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PropertyExample1
{
   class Program
   {
      static void Main(string[] args)
      {
         Person person = new Person("Ib Havn", "12919");
         person.Age = 84;
         Console.WriteLine(person);

         #region C#3.0 version
         Person person1 = new Person { Name = "Peter Graulund",   Ssn = "12345" };
         Person person2 = new Person { Name = "Davit Devdariano", Ssn = "12121" };
         person1.Age = 34;
         person2.Age = 23;

         Console.WriteLine(person1);
         Console.WriteLine(person2);
         #endregion

         Console.ReadKey();
      }
   }
}
