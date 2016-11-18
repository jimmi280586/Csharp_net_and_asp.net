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
        private int choice = 0;
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
            RestartTimerPanel.Visible = false;
            ShutdownTimerPanel.Visible = true;
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
            AutoClosingMessageBox.Show("Your computer will now shutdown", "Caption", 5000);
            execute("shutdown", " /s");
        }

        private void startDiskPartitionCmdToolStripMenuItem_Click(object sender, EventArgs e)
        {
                        
            this.model.execute(choice);

        }

        private void cancelShutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("Shutdown have been canceled", "Caption", 5000);
            execute("shutdown", " /a");
           
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
            ShutdownTimerPanel.Visible = false;
            RestartTimerPanel.Visible = true;
            //AutoClosingMessageBox.Show("The computer will restart in " + model.timeCalc(), "Caption", 5000);
            //execute("restart", " /s /t " + model.timeCalc());
        }

        private void cancelRestartToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
