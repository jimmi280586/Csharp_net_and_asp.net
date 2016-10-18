using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndexerExampleBad
{
   class Person
   {
      private int age;

      public int Age
      {
         get { return age; }
         set { age = value; }
      }

      public Person( int age )
      {
         this.age = age;    // Newborn
      }
   }
}
