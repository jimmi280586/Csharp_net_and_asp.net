using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CmdController1._0
{
    public class CmdController
    {
  
        public static void execute(String cmd1, String cmd2)
        {
            var psitimer = new ProcessStartInfo(cmd1, cmd2);
            psitimer.CreateNoWindow = true;
            psitimer.UseShellExecute = false;
            Process.Start(psitimer);
        }


    }
}
