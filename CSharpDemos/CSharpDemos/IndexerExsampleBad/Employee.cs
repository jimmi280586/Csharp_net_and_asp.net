using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndexerExampleBad
{
   class Employee : Person
   {
      private int [] SalaryArray;

      public Employee( int initial_age, int initial_salary )
         : base( initial_age )
         {
            this.salary = initial_salary;
            SalaryArray = new int[initial_age];
         }

      private int salary;

      public int Salary
      {
         get { return salary; }
         set { salary = value; }
      }




      // VERY BAD STYLE: using an indexer to access
      // the salary of an employee.
      public double this[int year]
      {
         get
         {
            return SalaryArray[year];

         }
      }
  
   }
}
