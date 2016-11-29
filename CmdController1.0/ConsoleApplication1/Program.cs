using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CmdController1._0;

namespace ConsoleApplication1
{
    public class Program
    {
        public static void Main()
        {
            AutoClosingMessageBox.Show("main in console", "caption", 5000);
            CmdWebserviceController.WebserviceFirstPartRunnerAsync(@"G:\test\Testing", "testingweb", "ITest", @"K:\jar_files\axis2-1.7.3\repository\services");
           // Console.ReadKey();
           // CmdWebserviceController.WebserviceSecondPartRunnerAsync(@"G:\test\Testing", "testingweb", "ITest", @"K:\jar_files\axis2-1.7.3\repository\services");
          //  Console.ReadKey();
          //  CmdWebserviceController.WebserviceAntFileUpdateRunnerAsync(@"G:\test\Testing", "testingweb", "ITest", @"K:\jar_files\axis2-1.7.3\repository\services");
          //  Console.ReadKey();
            
        }
        
    }
}
