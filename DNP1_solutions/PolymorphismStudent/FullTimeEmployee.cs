using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismStudent
{
   public class FullTimeEmployee: Employee 
    {
        private double monthlySalary;
        public FullTimeEmployee(string name, double monthlySalary) :base(name)
         {            
            this.monthlySalary = monthlySalary;
         }

        public override double getMonthSalary()
        {
            return this.monthlySalary;
        }

   
        public override string ToString()
        {
            return base.getName() + ", " + this.monthlySalary;
        }
    }
}
