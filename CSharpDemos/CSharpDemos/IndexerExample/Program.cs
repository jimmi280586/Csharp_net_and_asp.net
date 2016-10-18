using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndexerExample
{

   class Program
   {
      static void Main(string[] args)
      {
         NickNames nn = new NickNames();

         nn["Peter Graulund"] = "Legend";
         nn["Jacob Poulsen"]  = "Judas !!";
         nn["Juval Löwy"]     = ".NET jedi master";
         nn["Duncan"]         = "Yet another Yellow Judas";

         Console.WriteLine(nn["Juval Löwy"]);
      

         // Wait for CR
         Console.ReadLine();
      }
   }
}
