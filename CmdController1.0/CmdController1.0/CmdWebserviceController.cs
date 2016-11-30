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
        //fields 
        private static string tbRootPath;
        private static string tbDestPath;
        private static string tbpackPath;
        private static string tbinterPath;

        //standard getters and settets for fields
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

        //async methods for making shure the methods does not stall the main thread
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
       
        private static void WebserviceFirstPartRunner(String projectPath, String packageName, String interfaceName, String axis2Path)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe"); //sets the process program to cmd.exe
            processStartInfo.WorkingDirectory = projectPath; //sets the start directory where the process must start
            processStartInfo.RedirectStandardInput = true; //enable input from external program in this case c# application
            processStartInfo.RedirectStandardOutput = true; // enables the output to be usable in an external application other then cmd.exe
            processStartInfo.UseShellExecute = false;//makes the C# application to not open its own shell to execute

            Process process = Process.Start(processStartInfo); // starts the cmd.exe with the given settings

            if (process != null) // if the process does not exist
            {
                process.StandardInput.WriteLine(@"cd bin"); // move to bi folder at the path
                process.StandardInput.WriteLine(@"java2wsdl -cn " + packageName + "." + interfaceName); //create the wsdl file with the given parameters
                process.StandardInput.WriteLine(@"move *.wsdl " + projectPath); // move the wsdl file to the given projectpath
                process.StandardInput.WriteLine(@"cd .."); //move the cmd promt back to the start folder       

                //create the skeleton methods and structure using the given parameters. this is the line it does not run exept in the main console application      
                process.StandardInput.WriteLine(@"wsdl2java –uri " + interfaceName + ".wsdl –p " + packageName + ".skeleton –d adb -s –ss –sd –ssi");

                process.StandardInput.Close(); // line added to stop process from hanging on ReadToEnd()

                //makes the string for output not nesesary to use unless you want to return the entire process

                string outputString = process.StandardOutput.ReadToEnd();


                //return outputString;
            }

            AutoClosingMessageBox.Show("First part of webservice is compleated", "Caption", 5000);

            //opens a messagebox with the given text and auto closes after 5 seconds
        
    }

        private static void WebserviceSecondPartRunner(String projectPath, String packageName, String interfaceName, String axis2Path)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe"); //sets the process program to cmd.exe
            processStartInfo.WorkingDirectory = projectPath; //sets the start directory where the process must start
            processStartInfo.RedirectStandardInput = true; //enable input from external program in this case c# application
            processStartInfo.RedirectStandardOutput = true; // enables the output to be usable in an external application other then cmd.exe
            processStartInfo.UseShellExecute = false;//makes the C# application to not open its own shell to execute

            Process process = Process.Start(processStartInfo); // starts the cmd.exe with the given settings

            if (process != null) // if the process does not exist
            {
                process.StandardInput.WriteLine(@"ant jar.server");//create ant file
                process.StandardInput.WriteLine(@"cd build\lib");//move to path
                process.StandardInput.WriteLine(@"move *.aar " + axis2Path);//move the ant file to axis service folder
                process.StandardInput.WriteLine(@"cd ..");//move one folder back
                process.StandardInput.WriteLine(@"cd ..");//move one folder bak
                //create the stub file and folder in the webservice project
                process.StandardInput.WriteLine(@"wsdl2java –uri " + interfaceName + ".wsdl –p " + packageName + ".stub –d adb -s");
                
                process.StandardInput.Close(); // line added to stop process from hanging on ReadToEnd()

                //makes the string for output not nesesary to use unless you want to return the entire process

                string outputString = process.StandardOutput.ReadToEnd();
                //return outputString;
            }

            //opens a messagebox with the given text and auto closes after 5 seconds
            AutoClosingMessageBox.Show("Second part of webservice is compleated","Caption",5000);
        }
        private static void WebserviceAntFileUpdateRunner(String projectPath, String packageName, String interfaceName, String axis2Path)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe"); //sets the process program to cmd.exe
            processStartInfo.WorkingDirectory = projectPath; //sets the start directory where the process must start
            processStartInfo.RedirectStandardInput = true; //enable input from external program in this case c# application
            processStartInfo.RedirectStandardOutput = true; // enables the output to be usable in an external application other then cmd.exe
            processStartInfo.UseShellExecute = false;//makes the C# application to not open its own shell to execute

            Process process = Process.Start(processStartInfo); // starts the cmd.exe with the given settings

            if (process != null) // if the process does not exist
            {
                process.StandardInput.WriteLine(@"ant jar.server");//create ant file
                process.StandardInput.WriteLine(@"cd build\lib");// go to path
                process.StandardInput.WriteLine(@"move *.aar " + axis2Path);//move ant file to axis service folder path

                process.StandardInput.Close(); // line added to stop process from hanging on ReadToEnd()

                //makes the string for output not nesesary to use unless you want to return the entire process

                string outputString = process.StandardOutput.ReadToEnd();
                //return outputString;
            }
            //opens a messagebox with the given text and auto closes after 5 seconds
            AutoClosingMessageBox.Show("ant file updated ", "Caption", 5000);
        }
    }
}
