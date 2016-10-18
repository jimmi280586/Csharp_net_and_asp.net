using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndexerExample2
{
   class Program
   {
      static void Main(string[] args)
      {
         // Create new instance and assign elements
         // ... in the array through the indexer.
         Layout layout = new Layout();
         layout[1] = "Martin Jørgensen";
         layout[3] = "Osama Akharraz";
         layout[10] = "Peter Graulund";
         layout[11] = "Peter Sørensen";
         layout[-1] = "Error";
         layout[1000] = "Error";

         // Read elements through the indexer.
         string value1 = layout[1];
         string value2 = layout[3];
         string value3 = layout[10];
         string value4 = layout[11];
         string value5 = layout[50];
         string value6 = layout[-1];

         // Write the results.
         Console.WriteLine(value1);
         Console.WriteLine(value2);
         Console.WriteLine(value3);
         Console.WriteLine(value4);
         Console.WriteLine(value5); // Is null
         Console.WriteLine(value6);

         Console.ReadKey();

      }
   }
}
