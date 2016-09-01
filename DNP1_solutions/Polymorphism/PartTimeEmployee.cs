﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class PartTimeEmployee: Employee
    {
        private double hourlyWage;
        private int hoursPerMonth;

        public PartTimeEmployee(String name, double hourlyWage, int hoursPerMonth) :base(name)
        {
            this.hourlyWage = hourlyWage;
            this.hoursPerMonth = hoursPerMonth;
        }

        public override double getMonthSalary()
        {
            return (this.hoursPerMonth * this.hourlyWage);

        }
    }
}
