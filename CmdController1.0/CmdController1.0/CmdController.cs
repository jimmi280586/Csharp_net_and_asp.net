using System;
using System.Diagnostics;

namespace CmdController1._0
{
    public class CmdController
    {
        public int cmdComand(String comand)
        {
            var psitimer = new ProcessStartInfo(comand);
            try
            {
                //psitimer.CreateNoWindow = true;
                //psitimer.UseShellExecute = false;
                Process.Start(psitimer);
                return 0; //for testing purpose
            }
            catch
            {
                return 1; // for testing purpose
            }
        }
    }
}
