using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismStudent
{
    class PartTimeStudent : IStudent
    {
        private int year;
        public PartTimeStudent(int year)
        {
            this.year = year;
        }

        public void Registre(int year)
        {
            this.year = year;
        }

        public int getYear()
        {
            return this.year;
        }
      
    }
}
