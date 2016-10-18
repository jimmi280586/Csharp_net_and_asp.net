using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericExample
{
   public class Customer
   {
      public Customer(int id, string name)
      {
         Id = id;
         Name = name;
      }

      public string Name { get; set; }
      public int Id { get; set; }
   }
}
