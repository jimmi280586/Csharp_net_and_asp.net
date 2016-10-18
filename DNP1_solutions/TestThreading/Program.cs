using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Threading;

namespace TestThreading
   {
    class Program
    {
        static  void Main(string[] args)
        {
            //Console.WriteLine( "Write first file name" );
            //string s1 = Console.ReadLine();
            //Console.WriteLine("Write secondfile name");
            //string s2 = Console.ReadLine();
            string s1 = @"C:\tmp\test1.txt";
            string s2 = @"C:\tmp\test2.txt";

            if ( s1 != null && s2 != null )
            {
                Reader a = new Reader( s1 );
                Reader b = new Reader( s2 );
                Thread ta = new Thread( a.Read );
                Thread tb = new Thread( b.Read );
                ta.Start();
                tb.Start();

                #region VERY IMPORTANT
                ta.Join(); // Wait for thread
                tb.Join(); // Wait for thread
                #endregion
                
                if (a.data.Length == b.data.Length)
                {
                    if (a.data == b.data)
                    {
                        Console.WriteLine("Files {0} and {1} are equal", s1, s2);
                    }
                    else 
                    {
                        Console.WriteLine("Files {0} and {1} are not equal", s1, s2);
                    }
                }
                else
                {
                    Console.WriteLine("Files {0} and {1} are not equal", s1, s2 );
                }

                #region use_async
 //               UseAsync();
                #endregion

            }
            else
            {
                Console.WriteLine("-- enter two file names");
            }

            Console.ReadKey();
        }


        private static async void UseAsync()
        {
            string s1 = @"C:\tmp\test1.txt";
            string s2 = @"C:\tmp\test2.txt";

            if (s1 != null && s2 != null)
            {
                Reader a = new Reader(s1);
                Reader b = new Reader(s2);


                await Task.WhenAll( a.ReadAllLinesAsync(), b.ReadAllLinesAsync());
                
                
                if (a.data.Length == b.data.Length)
                {
                    if (a.data == b.data)
                    {
                        Console.WriteLine("Files {0} and {1} are equal", s1, s2);
                    }
                    else
                    {
                        Console.WriteLine("Files {0} and {1} are not equal", s1, s2);
                    }
                }
                else
                {
                    Console.WriteLine("Files {0} and {1} are not equal", s1, s2);
                }
            }

        }
    }
}
