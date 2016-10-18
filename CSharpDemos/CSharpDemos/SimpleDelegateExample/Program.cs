using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleDelegateExample
{
   class Program
   {
      delegate void Notifier(string sender);	// ordinary method signature 
                                             // with the keyword delegate

      static void SayHello( string sender ) 
      {
		   Console.WriteLine( "Hello from " + sender );
	   }

      #region another
      static void SayGoodBye( string sender )
      {
         Console.WriteLine( "Good bye from " + sender );
      }
      #endregion

      static void Main(string[] args)
      {
         Notifier greetings;
         greetings = SayHello;

         greetings("Kim");
         greetings("Rasmus");

         #region another
         greetings = SayGoodBye;
         greetings("Kim");
         greetings("Armen");
         #endregion

         #region multicast
         greetings = SayHello;
         greetings += SayGoodBye;
         greetings("Kim");
         #endregion


         Console.ReadKey();

      }
   }
}
