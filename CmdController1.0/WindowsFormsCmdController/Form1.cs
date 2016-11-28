using CmdController1._0;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsCmdController
{
    public partial class Form1 : Form
    {
        private CmdShutdownController model = new CmdShutdownController();
               
        public Form1()
        {
            InitializeComponent();
            
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void shutdownComandsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void shutdownOnTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        
        private void TextBoxShutdownTimer_TextChanged(object sender, EventArgs e)
        {
                      
        }

        private void HoursBox_ValueChanged(object sender, EventArgs e)
        {
            this.model.hour = HoursBox.Value;
        }

        private void MinutsBox_ValueChanged(object sender, EventArgs e)
        {
            this.model.min = MinutsBox.Value;
        }

        private void SecondsBox_ValueChanged(object sender, EventArgs e)
        {
            this.model.sec = SecondsBox.Value;
        }

        private void shutdownNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void startDiskPartitionCmdToolStripMenuItem_Click(object sender, EventArgs e)
        {         
        }

        private void cancelShutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
                     
        }       

        private void ShutdownTimerExecute_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("The computer will shutdown in " + model.timeCalc(), "Caption", 5000);
            CmdController.execute("shutdown", " /s /t " + model.timeCalc());
        }       

        private void restartNowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void restartOnTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void cancelRestartToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.model.hour = numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            this.model.min = numericUpDown2.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            this.model.sec = numericUpDown3.Value;
        }

        private void executeRestart_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("The computer will restart in " + model.timeCalc(), "Caption", 5000);
            CmdController.execute("shutdown", " /r /t " + model.timeCalc());
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("Shutdown have been canceled", "Caption", 5000);
            CmdController.execute("shutdown", " /a");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("Your computer will now shutdown", "Caption", 5000);
            CmdController.execute("shutdown", " /s");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("Restart have been canceled", "Caption", 5000);
            CmdController.execute("shutdown", " /a");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("Your computer will now restart", "Caption", 5000);
            CmdController.execute("shutdown", " /r");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("Disk partition cmd tool will now start", "Caption", 5000);
            Process.Start("diskpart.exe");
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CmdLoadController.loadNewFile();
            string path = @"" + CmdLoadController.userSelectedPath;
            tbFilePath.Text = CmdLoadController.userSelectedPath;
            AutoClosingMessageBox.Show("File will be deleted", "Caption", 5000);
            CmdDeleteController.deleteFile(path);
            AutoClosingMessageBox.Show("File were deleted", "Caption", 3000);
        }   

        private void button7_Click(object sender, EventArgs e)
        {
            CmdLoadController.loadNewFolder();
            string path = @"" + CmdLoadController.userSelectedPath;
            tbFilePath.Text = CmdLoadController.userSelectedPath;
            AutoClosingMessageBox.Show("Folder and all subfolders will be deleted", "Caption", 5000);
            CmdDeleteController.DeleteDirectory(path);
            AutoClosingMessageBox.Show("Folder were deleted", "Caption", 3000);
        }      

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void tbFilePath_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            CmdLoadController.loadNewFolder();
            string path = @"" + CmdLoadController.userSelectedPath;
            CmdLoadController.rootSelectedPath = CmdLoadController.userSelectedPath;
            rootPath.Text = CmdLoadController.rootSelectedPath;
            AutoClosingMessageBox.Show("Root folder have been found", "Caption", 5000);
          
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CmdLoadController.loadNewFolder();
            string path = @"" + CmdLoadController.userSelectedPath;
            CmdLoadController.destSelectedPath = CmdLoadController.userSelectedPath;
            destinationPath.Text = CmdLoadController.destSelectedPath;
            AutoClosingMessageBox.Show("Destination folder have been found", "Caption", 5000);
          
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CmdFileController.moveAllFilesAsync(CmdLoadController.rootSelectedPath, CmdLoadController.destSelectedPath);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            CmdLoadController.loadNewFolder();
            string path = @"" + CmdLoadController.userSelectedPath;
            CmdLoadController.rootSelectedPath = CmdLoadController.userSelectedPath;
            rootFolderCopy.Text = CmdLoadController.rootSelectedPath;
            AutoClosingMessageBox.Show("Root folder have been found", "Caption", 5000);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CmdLoadController.loadNewFolder();
            string path = @"" + CmdLoadController.userSelectedPath;
            CmdLoadController.destSelectedPath = CmdLoadController.userSelectedPath;
            destFolderCopy.Text = CmdLoadController.destSelectedPath;
            AutoClosingMessageBox.Show("Destination folder have been found", "Caption", 5000);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            CmdFileController.copyAllFilesAsync(CmdLoadController.rootSelectedPath, CmdLoadController.destSelectedPath);
            
        }
    }
}
