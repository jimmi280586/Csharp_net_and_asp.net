﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmdController1._0
{
    public class CmdShutdownController
    {
        public decimal hour { get; set; }
        public decimal min { get; set; }
        public decimal sec { get; set; }
        public decimal timer { get; set; }

        public decimal timeCalc()
        {
            this.timer = (this.hour * 60 * 60) + (this.min * 60);
            this.timer += this.sec;
            return this.timer;
        }

    }
}