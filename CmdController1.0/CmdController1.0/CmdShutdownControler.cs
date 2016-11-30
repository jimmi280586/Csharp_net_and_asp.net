using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmdController1._0
{
    public class CmdShutdownController
    {
        //fields for storing hour,min,seconds and timer
        public decimal hour { get; set; }
        public decimal min { get; set; }
        public decimal sec { get; set; }
        public decimal timer { get; set; }

        public decimal timeCalc()//calculating method for getting the time for shutdowns
        {
            this.timer = (this.hour * 60 * 60) + (this.min * 60);
            this.timer += this.sec;
            return this.timer;//returns the calculated time in seconds eksample 2 hours = 120 minuts = 7200 seconds
        }

    }
}
