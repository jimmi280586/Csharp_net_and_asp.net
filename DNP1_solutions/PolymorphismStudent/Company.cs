using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismStudent
{
    public class Company
    {
        private Employee[] employs;
        private int index = 0;

        public Company(int enicialEmployeeSize)
        {
            employs = new Employee[enicialEmployeeSize];
        }

        public double getMonthlySalaryTotal()
        {
            double totalSalary = 0;
            foreach(Employee employee in employs)
            {
                totalSalary += employee.getMonthSalary();
            }
            return totalSalary;
        }

        public void employNewEmployee(string name, double monthlySalary, double hourlyWage, int hoursPerMonth, int employeeType, int studentYear)
        {
            if(index == employs.GetLength(0))
            {
                int input;
                Console.WriteLine("last space in memory. Do you wish to make memory bigger press y for yes or n for no");
                input = Console.Read();
                if(input == 89 || input == 121)
                {
                    changeMemorySize();
                }
            }
            if (employeeType == 0)
            {
                employs[index] = new FullTimeEmployee(name, monthlySalary);
                index++;
            }
            if(employeeType == 1)
            {
                employs[index] = new PartTimeEmployee(name, hourlyWage, hoursPerMonth, studentYear);
                index++;
            }
        }

        public Employee getEmployee(string name)
        {
            int i = 0;
            while(!(employs[i].getName().Equals(name)))
            {
                i++;
            }
            return employs[i];
        }


        private void changeMemorySize()
        {
            int size = employs.GetLength(0) * 2;
            Employee[] temp = new Employee[size];
            for(int i = 0; i < employs.GetLength(0); i++)
            {
                temp[i] = employs[i];
            }
            employs = temp;
            Console.WriteLine(employs.GetLength(0));
            Console.WriteLine("memory has been successfully changed press any key to continue program.");
            Console.ReadKey();

        }
    }
}
