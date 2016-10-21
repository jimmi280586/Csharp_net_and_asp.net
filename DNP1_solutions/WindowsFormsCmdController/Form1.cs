using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCmdController
{
    public partial class Form1 : Form
    {
        decimal hour, min, sec;
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
            MessageBox.Show("Your computer will now shutdown");
            var psinow = new ProcessStartInfo("shutdown", "/s /t 30");
            psinow.CreateNoWindow = true;
            psinow.UseShellExecute = false;
            Process.Start(psinow);
        }

        private void startDiskPartitionCmdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Disk partition commandline will now open");
            var psidisk = new ProcessStartInfo("diskpart");
            psidisk.CreateNoWindow = true;
            psidisk.UseShellExecute = false;
            Process.Start(psidisk);
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
            MessageBox.Show("Your computer will shutdown in " + res + " Seconds.");
            var psitimer = new ProcessStartInfo("shutdown", "/s /t " + res);
            psitimer.CreateNoWindow = true;
            psitimer.UseShellExecute = false;
            Process.Start(psitimer);           
        }
    }
}
