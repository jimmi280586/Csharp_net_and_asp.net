using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CmdController1._0
{
    public class CmdWebserviceController
    {
        private static string tbRootPath;
        private static string tbDestPath;
        private static string tbpackPath;
        private static string tbinterPath;

        public static void WebserviceFirstPartRunnerAsync(String projectPath, String packageName, String interfaceName, String axis2Path)
        {
            Task.Run(() => WebserviceFirstPartRunner( projectPath, packageName, interfaceName, axis2Path));
        }
        public static void WebserviceSecondPartRunnerAsync(String projectPath, String packageName, String interfaceName, String axis2Path)
        {
            Task.Run(() => WebserviceSecondPartRunner(projectPath, packageName, interfaceName, axis2Path));
        }
        public static void WebserviceAntFileUpdateRunnerAsync(String projectPath, String packageName, String interfaceName, String axis2Path)
        {
            Task.Run(() => WebserviceAntFileUpdateRunner(projectPath, packageName, interfaceName, axis2Path));
        }

        public static string rootSelectedPath
        {
            get { return tbRootPath; }
            set { tbRootPath = value; }
        }
        public static string destSelectedPath
        {
            get { return tbDestPath; }
            set { tbDestPath = value; }
        }
        public static string packageSelectedPath
        {
            get { return tbpackPath; }
            set { tbpackPath = value; }
        }
        public static string interfaceSelectedPath
        {
            get { return tbinterPath; }
            set { tbinterPath = value; }
        }
        public static String WebservicePartRunner(String projectPath, String packageName, String interfaceName, String axis2Path)
        {
            
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe");
            processStartInfo.WorkingDirectory = projectPath;
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.UseShellExecute = false;

            Process process = Process.Start(processStartInfo);

            if (process != null)
            {
                //process.StandardInput.WriteLine(@"cd bin");
               // process.StandardInput.WriteLine(@"java2wsdl -cn " + packageName + "." + interfaceName);
               // process.StandardInput.WriteLine(@"move *.wsdl " + projectPath);
                // process.StandardInput.WriteLine(@"cd ..");

                 process.StandardInput.WriteLine("WSDL2java –uri " + interfaceName + ".wsdl –p " + packageName + ".skeleton –d adb -s –ss –sd –ssi");
                process.StandardInput.WriteLine(@"cd ..");


                process.StandardInput.Close(); // line added to stop process from hanging on ReadToEnd()

                string outputString = process.StandardOutput.ReadToEnd();
                return outputString;
            }
            return String.Empty;
            //AutoClosingMessageBox.Show("First part of webservice is compleated", "Caption", 5000);
        }
        private static void WebserviceFirstPartRunner(String projectPath, String packageName, String interfaceName, String axis2Path)
        {
            MessageBox.Show("you are in the cmd");
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe");
            processStartInfo.WorkingDirectory = projectPath;
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.UseShellExecute = false;

            Process process = Process.Start(processStartInfo);

            if (process != null)
            {
                process.StandardInput.WriteLine(@"cd bin");
                process.StandardInput.WriteLine(@"java2wsdl -cn " + packageName + "." + interfaceName);
                MessageBox.Show("wsdl created");
                process.StandardInput.WriteLine(@"move *.wsdl " + projectPath);
                MessageBox.Show("wsdl moved");
                process.StandardInput.WriteLine(@"cd ..");
               
                process.StandardInput.WriteLine("wsdl2java –uri " + interfaceName + ".wsdl –p " + packageName + ".skeleton –d adb -s –ss –sd –ssi");
                MessageBox.Show("skeleton created");


                process.StandardInput.Close(); // line added to stop process from hanging on ReadToEnd()

                string outputString = process.StandardOutput.ReadToEnd();
               // return outputString;
            }
           // return String.Empty;
            //AutoClosingMessageBox.Show("First part of webservice is compleated", "Caption", 5000);
        }

        private static void WebserviceSecondPartRunner(String projectPath, String packageName, String interfaceName, String axis2Path)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe");
            processStartInfo.WorkingDirectory = projectPath;
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.UseShellExecute = false;

            Process process = Process.Start(processStartInfo);

            if (process != null)
            {
                process.StandardInput.WriteLine(@"ant jar.server");
                process.StandardInput.WriteLine(@"cd build\lib");
                process.StandardInput.WriteLine(@"move *.aar " + axis2Path);
                process.StandardInput.WriteLine(@"cd ..");
                process.StandardInput.WriteLine(@"cd ..");
                process.StandardInput.WriteLine(@"wsdl2java –uri " + interfaceName + ".wsdl –p " + packageName + ".stub –d adb -s");



                process.StandardInput.Close(); // line added to stop process from hanging on ReadToEnd()

                string outputString = process.StandardOutput.ReadToEnd();
                //return outputString;
            }
            //return String.Empty;
            AutoClosingMessageBox.Show("Second part of webservice is compleated","Caption",5000);
        }
        private static void WebserviceAntFileUpdateRunner(String projectPath, String packageName, String interfaceName, String axis2Path)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe");
            processStartInfo.WorkingDirectory = projectPath;
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.UseShellExecute = false;

            Process process = Process.Start(processStartInfo);

            if (process != null)
            {
                process.StandardInput.WriteLine(@"ant jar.server");
                process.StandardInput.WriteLine(@"cd build\lib");
                process.StandardInput.WriteLine(@"move *.aar " + axis2Path);



                process.StandardInput.Close(); // line added to stop process from hanging on ReadToEnd()

                string outputString = process.StandardOutput.ReadToEnd();
                //return outputString;
            }

            AutoClosingMessageBox.Show("ant file updated ", "Caption", 5000);
        }
    }
}
