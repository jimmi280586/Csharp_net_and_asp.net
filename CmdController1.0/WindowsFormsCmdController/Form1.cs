using CmdController1._0;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsCmdController
{
    public partial class Form1 : Form
    {
        private CmdModel model = new CmdModel();
        private decimal hour { get; set; }
        private decimal min { get; set; }
        private decimal sec { get; set; }
        private int choice;
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
            ShutdownTimerPanel.Visible = true;
        }

        private void TextBoxShutdownTimer_TextChanged(object sender, EventArgs e)
        {
                      
        }

        private void HoursBox_ValueChanged(object sender, EventArgs e)
        {
            hour = HoursBox.Value;
        }

        private void MinutsBox_ValueChanged(object sender, EventArgs e)
        {
            min = MinutsBox.Value;
        }

        private void SecondsBox_ValueChanged(object sender, EventArgs e)
        {
            sec = SecondsBox.Value;
        }

        private void shutdownNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("Your computer will now shutdown", "Caption", 5000);
          /**  MessageBox.Show("Your computer will now shutdown");
            var psinow = new ProcessStartInfo("shutdown", "/s /t 30");
            psinow.CreateNoWindow = true;
            psinow.UseShellExecute = false;
            Process.Start(psinow);
        */
        }

        private void startDiskPartitionCmdToolStripMenuItem_Click(object sender, EventArgs e)
        {
                        
            model.execute(choice);

        }

        private void cancelShutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shutdown have been canceled");
            var psicancel = new ProcessStartInfo("shutdown", "/a");
            psicancel.CreateNoWindow = true;
            psicancel.UseShellExecute = false;
            Process.Start(psicancel);
        }       

        private void ShutdownTimerExecute_Click(object sender, EventArgs e)
        {
            decimal res = (hour * 60 * 60) + (min * 60);
            res += sec;
            model.execute(choice)
            /*MessageBox.Show("Your computer will shutdown in " + res + " Seconds.");
            var psitimer = new ProcessStartInfo("shutdown", "/s /t " + res);
            psitimer.CreateNoWindow = true;
            psitimer.UseShellExecute = false;
            Process.Start(psitimer); 
            */          
        }
    }
}
