using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CmdController1._0
{
    public class CmdModel
    {
        private CmdController control = new CmdController();
        private String cmd { get; set; }
        public void execute(int execute)
        {
            switch(execute)
            {
                case 1:
                    cmd = cmdPrep(execute);
                    break;
            }
        }
        public String cmdPrep(int choice)
        {
            decimal timer = timerCal();
            string msg = "";
            if (choice == 1)
            {
                msg = "shutdown -s -t " + timer;
            }
            return "";
        }
        private decimal timerCal()
        {
            //CmdControllerView.Form1 form = 
            decimal res = 0;// ( * 60 * 60) + (min * 60);
            //res += sec;
            return res;
        }
        

    }
}
