using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismStudent
{
    public abstract class Employee
    {
        private string name;

        public Employee(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

  
        public abstract double getMonthSalary();

        public override abstract string ToString();
        

        
    }
}
