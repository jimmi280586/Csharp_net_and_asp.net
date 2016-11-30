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
        //method for executing simple comand that does not care where you enter it
        public static void execute(String cmd1, String cmd2)
        {
            var psitimer = new ProcessStartInfo(cmd1, cmd2);//enitiate new process taking two arguments
            psitimer.CreateNoWindow = true;//tells the system to not create the window normaly displayed
            psitimer.UseShellExecute = false; // tells to not use the chell to execute
            Process.Start(psitimer);//executes the process with the before given comands
        }


    }
}
