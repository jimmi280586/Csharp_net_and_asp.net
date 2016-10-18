using PolymorphismStudent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class TestMain
    {
        static void Main(string[] args)
        {
            Company ict = new Company(2);
            ict.employNewEmployee("Jimmi", 12000, 0, 0, 0, 0);
            ict.employNewEmployee("Lars", 0, 120, 160, 1, 2016);
            Console.WriteLine(ict.getMonthlySalaryTotal());
            Console.ReadKey();
            ict.employNewEmployee("Morten", 13000, 0, 0, 0, 0);
            ict.employNewEmployee("Marek", 0, 120, 160, 1, 2005);
            Console.WriteLine(ict.getMonthlySalaryTotal());
            Console.ReadKey();

            Console.WriteLine(ict.getEmployee("Jimmi"));
             Console.WriteLine(ict.getEmployee("Lars"));
             Console.WriteLine(ict.getEmployee("Morten"));
             Console.WriteLine(ict.getEmployee("Marek"));

            Console.ReadKey();
        }
    }
}
