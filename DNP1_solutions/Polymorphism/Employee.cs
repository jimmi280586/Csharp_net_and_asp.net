using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    abstract class Employee
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public Employee(string name)
        {
            this.name = name;
        }

        public abstract double getMonthSalary();
    }
}
