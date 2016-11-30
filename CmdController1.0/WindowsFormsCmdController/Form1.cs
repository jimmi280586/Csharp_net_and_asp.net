using CmdController1._0;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using ConsoleApplication1;

namespace WindowsFormsCmdController
{
    public partial class Form1 : Form
    {
        private CmdShutdownController model = new CmdShutdownController();
                       
        public Form1()
        {
            InitializeComponent();
            
        }
     
        private void HoursBox_ValueChanged(object sender, EventArgs e)
        {
            //sets the hour for timer calculation
            this.model.hour = HoursBox.Value;
        }

        private void MinutsBox_ValueChanged(object sender, EventArgs e)
        {
            //sets the minuts for timer calculations
            this.model.min = MinutsBox.Value;
        }

        private void SecondsBox_ValueChanged(object sender, EventArgs e)
        {
            //Sets the seconds for timer calculations
            this.model.sec = SecondsBox.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //sets the hour for timer calculation
            this.model.hour = numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            //sets the minuts for timer calculations
            this.model.min = numericUpDown2.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            //Sets the seconds for timer calculations
            this.model.sec = numericUpDown3.Value;
        }

        private void ShutdownTimerExecute_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("The computer will shutdown in " + model.timeCalc(), "Caption", 5000);
            CmdController.execute("shutdown", " /s /t " + model.timeCalc());//shutdown computer on timer
        }

        private void executeRestart_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("The computer will restart in " + model.timeCalc(), "Caption", 5000); //display message for 5 sec
            CmdController.execute("shutdown", " /r /t " + model.timeCalc());//execute this comand witch restart computer on timer
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("Shutdown have been canceled", "Caption", 5000);
            CmdController.execute("shutdown", " /a");//cancels restart or shutdown
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("Your computer will now shutdown", "Caption", 5000);
            CmdController.execute("shutdown", " /s");//shutdowm in less then one minut
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("Restart have been canceled", "Caption", 5000);
            CmdController.execute("shutdown", " /a");//cancels restart or shutdown
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("Your computer will now restart", "Caption", 5000);
            CmdController.execute("shutdown", " /r");//restart in less then one minut
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("Disk partition cmd tool will now start", "Caption", 5000);
            Process.Start("diskpart.exe");//start the diskpart cmd promt 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CmdLoadController.loadNewFile();//load file 
            string path = @"" + CmdLoadController.userSelectedPath;//set file path
            tbFilePath.Text = CmdLoadController.userSelectedPath;//display file path in textbox
            AutoClosingMessageBox.Show("File will be deleted", "Caption", 5000);//give warning to user that file will be deleted
            CmdDeleteController.deleteFile(path);//delete file
            AutoClosingMessageBox.Show("File were deleted", "Caption", 3000);//display to user that file were deleted
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CmdLoadController.loadNewFile();//load file 
            string path = @"" + CmdLoadController.userSelectedPath;//set file path
            tbFilePath.Text = CmdLoadController.userSelectedPath;//display file path in textbox
            AutoClosingMessageBox.Show("Folder and all subfolders will be deleted", "Caption", 5000);//give warning to user that folder will be deleted
            CmdDeleteController.DeleteDirectory(path);//delete all folders in the selected folder
            AutoClosingMessageBox.Show("Folder were deleted", "Caption", 3000);//display to user that folders and files were deleted
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            CmdLoadController.loadNewFolder();//load folder
            string path = @"" + CmdLoadController.userSelectedPath;//set path
            CmdLoadController.rootSelectedPath = CmdLoadController.userSelectedPath;//set root field to path
            rootPath.Text = CmdLoadController.rootSelectedPath;//display path in textbox
            AutoClosingMessageBox.Show("Root folder have been found", "Caption", 5000);//display to user that path were selected
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CmdLoadController.loadNewFolder();//load folder
            string path = @"" + CmdLoadController.userSelectedPath;//set path
            CmdLoadController.destSelectedPath = CmdLoadController.userSelectedPath;//set destination field to path
            destinationPath.Text = CmdLoadController.destSelectedPath;//display path in textbox
            AutoClosingMessageBox.Show("Destination folder have been found", "Caption", 5000);//diplay to user that path were selected
        }       

        private void button13_Click(object sender, EventArgs e)
        {
            CmdLoadController.loadNewFolder();//load folder
            string path = @"" + CmdLoadController.userSelectedPath;//set path
            CmdLoadController.rootSelectedPath = CmdLoadController.userSelectedPath;//set root field to path
            rootFolderCopy.Text = CmdLoadController.rootSelectedPath;//display path in textbox
            AutoClosingMessageBox.Show("Root folder have been found", "Caption", 5000);//display to user that path were selected
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CmdLoadController.loadNewFolder();//load folder
            string path = @"" + CmdLoadController.userSelectedPath;//set path
            CmdLoadController.destSelectedPath = CmdLoadController.userSelectedPath;//set destination field to path
            destFolderCopy.Text = CmdLoadController.destSelectedPath;//display path in textbox
            AutoClosingMessageBox.Show("Destination folder have been found", "Caption", 5000);//diplay to user that path were selected
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //moves all files from folder and sub folders in root to destination path not including frolders
            CmdFileController.moveAllFilesAsync(CmdLoadController.rootSelectedPath, CmdLoadController.destSelectedPath);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //copies all files in the root folder incl files in subfolders but not the folders it self to the given destination path
            CmdFileController.copyAllFilesAsync(CmdLoadController.rootSelectedPath, CmdLoadController.destSelectedPath);
        }

        //folder browser and locator for the project root path.
        private void button14_Click(object sender, EventArgs e)
        {
            CmdLoadController.loadNewFolder();//load the folder for axis2 service
            string path = @"" + CmdLoadController.userSelectedPath;//set path @ is used to tell the processes that \ must be used as they are
            CmdWebserviceController.rootSelectedPath = CmdLoadController.userSelectedPath;//set the path for the java project
            ProjectPathBox.Text = CmdWebserviceController.rootSelectedPath;//displays path in textbox
            AutoClosingMessageBox.Show("Project folder have been found", "Caption", 5000);//message box show message for 5 seconds
        }

        // folder browser and locator for the axis2 path to where the ant jar.server file should be moved to.
        private void button15_Click(object sender, EventArgs e)
        {
            CmdLoadController.loadNewFolder();//load the folder for axis2 service
            string path = @"" + CmdLoadController.userSelectedPath;//set path @ is used to tell the processes that \ must be used as they are
            CmdWebserviceController.destSelectedPath = CmdLoadController.userSelectedPath; //set the destination path for the ant file
            AxisPathBox.Text = CmdWebserviceController.destSelectedPath;//displays path in textbox
            AutoClosingMessageBox.Show("axis2 folder have been found", "Caption", 5000);//message box show message for 5 seconds
        }

        //button handler for the create skeleton and wsdl file of the webservice controller
        private void button16_Click(object sender, EventArgs e)
        {
            //creates and moves the wsdl file for the webservice. and creates the skeleton files and folder        
            CmdWebserviceController.WebserviceFirstPartRunnerAsync(@"" + ProjectPathBox.Text, PackageBox.Text, InterfaceNameBox.Text, @"" + AxisPathBox.Text);
        }

        //buttonhandler for create ant and stub in the webservice
        private void button18_Click(object sender, EventArgs e)
        {
            //creates the ant file and moves it to the axis 2 folder. and creates the stub folder and methods for the java webservice
            CmdWebserviceController.WebserviceSecondPartRunnerAsync(@"" + ProjectPathBox.Text, PackageBox.Text, InterfaceNameBox.Text, @"" + AxisPathBox.Text);
        }

        //button handler for updating the ant file
        private void button17_Click(object sender, EventArgs e)
        {
            //updates the ant file and moves it to the axis 2 path
            CmdWebserviceController.WebserviceAntFileUpdateRunnerAsync(@"" + ProjectPathBox.Text, PackageBox.Text, InterfaceNameBox.Text, @"" + AxisPathBox.Text);
        }
        //end of form rest is not used but if removed the program will give errors

        private void shutdownNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //not used
        }

        private void startDiskPartitionCmdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //not used
        }

        private void cancelShutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //not used        
        }           

        private void restartNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //not used
        }

        private void restartOnTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //not used
        }

        private void cancelRestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //not used
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //not used
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            //not used
        }   

        private void button6_Click(object sender, EventArgs e)
        {
            //not used
        }           

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            //not used
        }

        private void tbFilePath_TextChanged(object sender, EventArgs e)
        {
            //not used
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //not used
        }

        private void shutdownComandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //not used
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //not used
        }

        private void shutdownOnTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //not used
        }

        private void TextBoxShutdownTimer_TextChanged(object sender, EventArgs e)
        {
            //not used    
        }

    }
}
