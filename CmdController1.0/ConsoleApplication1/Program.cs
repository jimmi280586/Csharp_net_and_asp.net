using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine(ProcessRunner());
            Console.ReadKey();
            
        }
        private static string ProcessRunner()
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe");
            processStartInfo.WorkingDirectory = @"G:\test\Testing\bin";
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.UseShellExecute = false;

            Process process = Process.Start(processStartInfo);

            if (process != null)
            {
                process.StandardInput.WriteLine(@"java2wsdl -cn testingweb.ITest");
                process.StandardInput.WriteLine(@"G:\test\Testing\bin MOVE ITest.wsdl G:\test\Testing");
                //process.StandardInput.WriteLine("echo hello");
                //process.StandardInput.WriteLine("yourCommand.exe arg1 arg2");

                process.StandardInput.Close(); // line added to stop process from hanging on ReadToEnd()

                string outputString = process.StandardOutput.ReadToEnd();
                return outputString;
            }

            return string.Empty;
        }
    }
}
