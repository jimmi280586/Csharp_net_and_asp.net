using CmdController1._0;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsCmdController
{
    public partial class Form1 : Form
    {
        private CmdFunctions model = new CmdFunctions();
        private decimal hour { get; set; }
        private decimal min { get; set; }
        private decimal sec { get; set; }
        
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
            execute("shutdown", " /s /t " + model.timeCalc());
        }
        private void execute(String cmd1, String cmd2)
        {          
            var psitimer = new ProcessStartInfo(cmd1, cmd2);
            psitimer.CreateNoWindow = true;
            psitimer.UseShellExecute = false;
            Process.Start(psitimer);
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
            execute("shutdown", " /r /t " + model.timeCalc());
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("Shutdown have been canceled", "Caption", 5000);
            execute("shutdown", " /a");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("Your computer will now shutdown", "Caption", 5000);
            execute("shutdown", " /s");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("Restart have been canceled", "Caption", 5000);
            execute("shutdown", " /a");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("Your computer will now restart", "Caption", 5000);
            execute("shutdown", " /r");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("Disk partition cmd tool will now start", "Caption", 5000);
            Process.Start("diskpart.exe");
        }
    }
}
