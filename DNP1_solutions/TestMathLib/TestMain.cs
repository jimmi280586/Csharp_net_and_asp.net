using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMathLib
{
    class TestMain
    {
        static void Main(string[] args)
        {
            MathLib.Class1 print = new MathLib.Class1();
            Console.WriteLine("test add method from mathlib");
            Console.WriteLine(print.add(12, 12));
            Console.WriteLine("test sub method from mathlib");
            Console.WriteLine(print.sub(12, 3));
            Console.WriteLine("test multiply method from mathlib");
            Console.WriteLine(print.multiply(12, 12));
            Console.WriteLine("test divide method from mathlib");
            Console.WriteLine(print.divide(12, 2));
            Console.WriteLine("test divide method from mathlib test of exeption");
            Console.WriteLine(print.divide(12, 0));
            
            Console.ReadKey();

        }
    }
}
