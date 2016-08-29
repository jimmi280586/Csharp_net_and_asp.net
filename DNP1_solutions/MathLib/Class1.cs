using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    public class Class1
    {
        public double add(double a, double b)
        {
            return a + b;
        }

        public double sub(double a, double b)
        {
            return a - b;
        }

        public double multiply(double a, double b)
        {
            return a * b;
        }

        public double divide(double a, double b)
        {
            try
            {
                return a / b;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("exeption thrown  Parameter cannot be zero");
                return 0;
            }
           
        }
    }
}
