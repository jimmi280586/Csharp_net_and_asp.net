using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndexerExample
{
   class NickNames
   {
      public string this[string realName]
      {
         get
         {
            return (string)names[realName];
         }
         set
         {
            names[realName] = value;
         }
      }

      private System.Collections.Hashtable names = new System.Collections.Hashtable();
   }
}
