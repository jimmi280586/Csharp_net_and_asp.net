using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericExample
{
   class Program
   {
      static void Main(string[] args)
      {
         Dictionary<int, Customer> customers = new Dictionary<int, Customer>();

         Customer cust1 = new Customer(1, "Peter Graulund");
         Customer cust2 = new Customer(2, "Hjalte Bo");
         Customer cust3 = new Customer(3, "Davit Devdariani");
         Customer cust4 = new Customer(4, "Demba Ba");
         Customer cust5 = new Customer(5, "Scot Parker");



         customers.Add(cust1.Id, cust1);
         customers.Add(cust2.Id, cust2);
         customers.Add(cust3.Id, cust3);
         customers.Add(cust4.Id, cust4);
         customers.Add(cust5.Id, cust5);

         foreach (KeyValuePair<int, Customer> custKeyVal in customers)
         {
            Console.WriteLine(
                "Customer Id: {0}, Name: {1}",
                custKeyVal.Key,
                custKeyVal.Value.Name);
         }

        // customers.sort();
         #region var
         //foreach (var k in customers)
         //{
         //   Console.WriteLine(
         //       "Customer Id: {0}, Name: {1}",
         //       k.Key,
         //       k.Value.Name);
         //}
         #endregion


         Console.ReadKey();
      }
   }
}
