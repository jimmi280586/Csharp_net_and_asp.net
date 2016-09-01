using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBusTaxApplication
{
    class Bus: Vehicle, ITaxable
    {
        protected int numberOfSeats;

        public decimal TaxValue()
        {
            return 22;
        }
    }
}
