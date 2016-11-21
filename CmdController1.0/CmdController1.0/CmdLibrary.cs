using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmdController1._0
{
    public class CmdLibrary
    {
        private CmdComand[] comands;

        public CmdLibrary()
        {
            this.comands = readCmdDatabase();
        }

        private CmdComand[] readCmdDatabase()
        {
            CmdComand[] temp = new CmdComand[3];
            return temp;
        }
    }
}
