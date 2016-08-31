using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World");

            Test.TestMain a = new Test.TestMain();
            string b = a.testMe();
            Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}
