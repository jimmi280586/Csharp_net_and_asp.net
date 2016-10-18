using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PropertyExample1
{
   class Person
   {
      public Person()
      {
      }

      public Person(string name, string ssn)
      {
         this.ssn = ssn;
         this.name = name;
      }

      private string name;
      public string Name
      {
         get { return name; }
         set { name = value; }
      }

      private string ssn;
      public string Ssn
      {
         get { return ssn; }
         set { ssn = value; }
      }

      // C# 3.0 automatic property
      public int Age { get; set; }



      public override string ToString()
      {
         return name + " " + ssn + " age=" + Age;
      }
   }
}
