using CmdController1._0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            CmdWebserviceController.WebserviceFirstPartRunnerAsync(@"G:\test\Testing", "testingweb", "ITest", @"K:\jar_files\axis2-1.7.3\repository\services");
            Console.ReadKey();
            CmdWebserviceController.WebserviceSecondPartRunnerAsync(@"G:\test\Testing", "testingweb", "ITest", @"K:\jar_files\axis2-1.7.3\repository\services");
            Console.ReadKey();
            CmdWebserviceController.WebserviceAntFileUpdateRunnerAsync(@"G:\test\Testing", "testingweb", "ITest", @"K:\jar_files\axis2-1.7.3\repository\services");
            Console.ReadKey();
        }
    }
}
