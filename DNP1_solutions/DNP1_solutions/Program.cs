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

            Test.Class1 a = new Test.Class1();
            string b = a.testMe();
            Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}
