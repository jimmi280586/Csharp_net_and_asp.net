using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBusTaxApplication
{
    class House : FixedProperty, ITaxable
    {
        protected double area;

        decimal ITaxable.TaxValue()
        {
            return 52;
        }
    }
}
