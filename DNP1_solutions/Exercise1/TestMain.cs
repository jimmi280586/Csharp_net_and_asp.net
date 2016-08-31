using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class TestMain
    {
        static void Main(string[] args)
        {
            Exercise1_library.Class1 print = new Exercise1_library.Class1();
            Console.WriteLine("numbers from 100-202 printed every second time");
            print.print_every_second();
            Console.WriteLine("numbers from 100-202 printed every second time in reverse order");
            print.print_every_second_reverse();
            Console.WriteLine("exercise 1.3");
            print.Print_exercise_1_03();
            Console.WriteLine("exercise 1.4");
            print.print_exercise_1_04();
            Console.WriteLine("exercise 1.5");
            Console.WriteLine(print.makeSomeNoise());
            Console.ReadKey();
        }
    }
}
