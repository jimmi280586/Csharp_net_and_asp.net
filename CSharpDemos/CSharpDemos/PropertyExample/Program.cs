using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PropertyExample
{
   class Button
   {
      public string Caption
      {
         get
         {
            return caption;
         }
         set
         {
            caption = value;
         }
      }
      private string caption;

      private int test = 0;
      public int Test
      {
         get { return test; }

      }


   }
   class Program
   {
      static void Main(string[] args)
      {
         Button button = new Button();
         button.Caption = "Click!!";



          button.Caption += " What the hack is this?!";

         Console.WriteLine(button.Caption);

         // Wait for CR
         Console.ReadLine();
      }
   }
}
