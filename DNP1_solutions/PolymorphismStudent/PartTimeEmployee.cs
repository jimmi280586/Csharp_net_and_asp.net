using PolymorphismStudent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismStudent
{
    class PartTimeEmployee: Employee
    {
        private double hourlyWage;
        private int hoursPerMonth;
        private IStudent amStudent;

        public PartTimeEmployee(String name, double hourlyWage, int hoursPerMonth, int year) :base(name)
        {
            this.hourlyWage = hourlyWage;
            this.hoursPerMonth = hoursPerMonth;
            amStudent = new PartTimeStudent(year);
           
        }

        public override double getMonthSalary()
        {
            return this.hoursPerMonth * this.hourlyWage;

        }

     
        public override string ToString()
        {
            return base.getName() + ", " + this.hourlyWage + ", " + hoursPerMonth + ", " + amStudent.getYear();
        }
    }
}
