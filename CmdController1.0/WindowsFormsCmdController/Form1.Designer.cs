namespace WindowsFormsCmdController
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.shutdownComandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutdownNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutdownOnTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelShutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartComandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartOnTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelRestartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveFilesFromSubToParentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceMoveFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyFilesFromSubToParrentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceCopyFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceDeletFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllFilesInDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diskParttitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startDiskPartitionCmdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installWebserviceInEclipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShutdownTimerPanel = new System.Windows.Forms.Panel();
            this.RestartTimerPanel = new System.Windows.Forms.Panel();
            this.ShutdownTimerExecute = new System.Windows.Forms.Button();
            this.TextBoxShutdownTimer = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MinutsBox = new System.Windows.Forms.NumericUpDown();
            this.SecondsBox = new System.Windows.Forms.NumericUpDown();
            this.HoursBox = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.ShutdownTimerPanel.SuspendLayout();
            this.RestartTimerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinutsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shutdownComandsToolStripMenuItem,
            this.restartComandsToolStripMenuItem,
            this.moveToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.deleteFilesToolStripMenuItem,
            this.diskParttitionToolStripMenuItem,
            this.installWebserviceInEclipseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(697, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // shutdownComandsToolStripMenuItem
            // 
            this.shutdownComandsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shutdownNowToolStripMenuItem,
            this.shutdownOnTimerToolStripMenuItem,
            this.cancelShutdownToolStripMenuItem});
            this.shutdownComandsToolStripMenuItem.Name = "shutdownComandsToolStripMenuItem";
            this.shutdownComandsToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.shutdownComandsToolStripMenuItem.Text = "Shutdown Comands";
            this.shutdownComandsToolStripMenuItem.Click += new System.EventHandler(this.shutdownComandsToolStripMenuItem_Click);
            // 
            // shutdownNowToolStripMenuItem
            // 
            this.shutdownNowToolStripMenuItem.Name = "shutdownNowToolStripMenuItem";
            this.shutdownNowToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.shutdownNowToolStripMenuItem.Text = "Shutdown now";
            this.shutdownNowToolStripMenuItem.Click += new System.EventHandler(this.shutdownNowToolStripMenuItem_Click);
            // 
            // shutdownOnTimerToolStripMenuItem
            // 
            this.shutdownOnTimerToolStripMenuItem.Name = "shutdownOnTimerToolStripMenuItem";
            this.shutdownOnTimerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.shutdownOnTimerToolStripMenuItem.ShowShortcutKeys = false;
            this.shutdownOnTimerToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.shutdownOnTimerToolStripMenuItem.Text = "Shutdown on timer";
            this.shutdownOnTimerToolStripMenuItem.Click += new System.EventHandler(this.shutdownOnTimerToolStripMenuItem_Click);
            // 
            // cancelShutdownToolStripMenuItem
            // 
            this.cancelShutdownToolStripMenuItem.Name = "cancelShutdownToolStripMenuItem";
            this.cancelShutdownToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.cancelShutdownToolStripMenuItem.Text = "Cancel Shutdown";
            this.cancelShutdownToolStripMenuItem.Click += new System.EventHandler(this.cancelShutdownToolStripMenuItem_Click);
            // 
            // restartComandsToolStripMenuItem
            // 
            this.restartComandsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartNowToolStripMenuItem,
            this.restartOnTimerToolStripMenuItem,
            this.cancelRestartToolStripMenuItem});
            this.restartComandsToolStripMenuItem.Name = "restartComandsToolStripMenuItem";
            this.restartComandsToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.restartComandsToolStripMenuItem.Text = "Restart Comands";
            // 
            // restartNowToolStripMenuItem
            // 
            this.restartNowToolStripMenuItem.Name = "restartNowToolStripMenuItem";
            this.restartNowToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.restartNowToolStripMenuItem.Text = "Restart now";
            this.restartNowToolStripMenuItem.Click += new System.EventHandler(this.restartNowToolStripMenuItem_Click);
            // 
            // restartOnTimerToolStripMenuItem
            // 
            this.restartOnTimerToolStripMenuItem.Name = "restartOnTimerToolStripMenuItem";
            this.restartOnTimerToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.restartOnTimerToolStripMenuItem.Text = "Restart on Timer";
            this.restartOnTimerToolStripMenuItem.Click += new System.EventHandler(this.restartOnTimerToolStripMenuItem_Click);
            // 
            // cancelRestartToolStripMenuItem
            // 
            this.cancelRestartToolStripMenuItem.Name = "cancelRestartToolStripMenuItem";
            this.cancelRestartToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.cancelRestartToolStripMenuItem.Text = "Cancel Restart";
            this.cancelRestartToolStripMenuItem.Click += new System.EventHandler(this.cancelRestartToolStripMenuItem_Click);
            // 
            // moveToolStripMenuItem
            // 
            this.moveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveFilesFromSubToParentToolStripMenuItem,
            this.forceMoveFilesToolStripMenuItem});
            this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
            this.moveToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.moveToolStripMenuItem.Text = "Move";
            // 
            // moveFilesFromSubToParentToolStripMenuItem
            // 
            this.moveFilesFromSubToParentToolStripMenuItem.Name = "moveFilesFromSubToParentToolStripMenuItem";
            this.moveFilesFromSubToParentToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.moveFilesFromSubToParentToolStripMenuItem.Text = "Move files from sub to parent";
            // 
            // forceMoveFilesToolStripMenuItem
            // 
            this.forceMoveFilesToolStripMenuItem.Name = "forceMoveFilesToolStripMenuItem";
            this.forceMoveFilesToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.forceMoveFilesToolStripMenuItem.Text = "force move files";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyFilesFromSubToParrentToolStripMenuItem,
            this.forceCopyFilesToolStripMenuItem});
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // copyFilesFromSubToParrentToolStripMenuItem
            // 
            this.copyFilesFromSubToParrentToolStripMenuItem.Name = "copyFilesFromSubToParrentToolStripMenuItem";
            this.copyFilesFromSubToParrentToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.copyFilesFromSubToParrentToolStripMenuItem.Text = "copy files from sub to parrent";
            // 
            // forceCopyFilesToolStripMenuItem
            // 
            this.forceCopyFilesToolStripMenuItem.Name = "forceCopyFilesToolStripMenuItem";
            this.forceCopyFilesToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.forceCopyFilesToolStripMenuItem.Text = "force copy files";
            // 
            // deleteFilesToolStripMenuItem
            // 
            this.deleteFilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forceDeletFilesToolStripMenuItem,
            this.deleteAllFilesInDirectoryToolStripMenuItem,
            this.deleteDirectoryToolStripMenuItem});
            this.deleteFilesToolStripMenuItem.Name = "deleteFilesToolStripMenuItem";
            this.deleteFilesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.deleteFilesToolStripMenuItem.Text = "Delete files";
            // 
            // forceDeletFilesToolStripMenuItem
            // 
            this.forceDeletFilesToolStripMenuItem.Name = "forceDeletFilesToolStripMenuItem";
            this.forceDeletFilesToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.forceDeletFilesToolStripMenuItem.Text = "force delet files";
            // 
            // deleteAllFilesInDirectoryToolStripMenuItem
            // 
            this.deleteAllFilesInDirectoryToolStripMenuItem.Name = "deleteAllFilesInDirectoryToolStripMenuItem";
            this.deleteAllFilesInDirectoryToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.deleteAllFilesInDirectoryToolStripMenuItem.Text = "delete all files in directory";
            // 
            // deleteDirectoryToolStripMenuItem
            // 
            this.deleteDirectoryToolStripMenuItem.Name = "deleteDirectoryToolStripMenuItem";
            this.deleteDirectoryToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.deleteDirectoryToolStripMenuItem.Text = "delete directory";
            // 
            // diskParttitionToolStripMenuItem
            // 
            this.diskParttitionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startDiskPartitionCmdToolStripMenuItem});
            this.diskParttitionToolStripMenuItem.Name = "diskParttitionToolStripMenuItem";
            this.diskParttitionToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.diskParttitionToolStripMenuItem.Text = "Disk parttition";
            // 
            // startDiskPartitionCmdToolStripMenuItem
            // 
            this.startDiskPartitionCmdToolStripMenuItem.Name = "startDiskPartitionCmdToolStripMenuItem";
            this.startDiskPartitionCmdToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.startDiskPartitionCmdToolStripMenuItem.Text = "start disk partition cmd";
            this.startDiskPartitionCmdToolStripMenuItem.Click += new System.EventHandler(this.startDiskPartitionCmdToolStripMenuItem_Click);
            // 
            // installWebserviceInEclipseToolStripMenuItem
            // 
            this.installWebserviceInEclipseToolStripMenuItem.Name = "installWebserviceInEclipseToolStripMenuItem";
            this.installWebserviceInEclipseToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.installWebserviceInEclipseToolStripMenuItem.Text = "install webservice in eclipse";
            // 
            // ShutdownTimerPanel
            // 
            this.ShutdownTimerPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ShutdownTimerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShutdownTimerPanel.Controls.Add(this.RestartTimerPanel);
            this.ShutdownTimerPanel.Location = new System.Drawing.Point(0, 27);
            this.ShutdownTimerPanel.Name = "ShutdownTimerPanel";
            this.ShutdownTimerPanel.Size = new System.Drawing.Size(697, 578);
            this.ShutdownTimerPanel.TabIndex = 7;
            this.ShutdownTimerPanel.Visible = false;
            // 
            // RestartTimerPanel
            // 
            this.RestartTimerPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.RestartTimerPanel.Controls.Add(this.ShutdownTimerExecute);
            this.RestartTimerPanel.Controls.Add(this.TextBoxShutdownTimer);
            this.RestartTimerPanel.Controls.Add(this.label3);
            this.RestartTimerPanel.Controls.Add(this.label2);
            this.RestartTimerPanel.Controls.Add(this.label1);
            this.RestartTimerPanel.Controls.Add(this.MinutsBox);
            this.RestartTimerPanel.Controls.Add(this.SecondsBox);
            this.RestartTimerPanel.Controls.Add(this.HoursBox);
            this.RestartTimerPanel.Location = new System.Drawing.Point(1, 1);
            this.RestartTimerPanel.Name = "RestartTimerPanel";
            this.RestartTimerPanel.Size = new System.Drawing.Size(655, 575);
            this.RestartTimerPanel.TabIndex = 8;
            // 
            // ShutdownTimerExecute
            // 
            this.ShutdownTimerExecute.Location = new System.Drawing.Point(580, 535);
            this.ShutdownTimerExecute.Name = "ShutdownTimerExecute";
            this.ShutdownTimerExecute.Size = new System.Drawing.Size(103, 28);
            this.ShutdownTimerExecute.TabIndex = 7;
            this.ShutdownTimerExecute.Text = "Execute";
            this.ShutdownTimerExecute.UseVisualStyleBackColor = true;
            this.ShutdownTimerExecute.Click += new System.EventHandler(this.ShutdownTimerExecute_Click);
            // 
            // TextBoxShutdownTimer
            // 
            this.TextBoxShutdownTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxShutdownTimer.Location = new System.Drawing.Point(69, 39);
            this.TextBoxShutdownTimer.Name = "TextBoxShutdownTimer";
            this.TextBoxShutdownTimer.Size = new System.Drawing.Size(529, 118);
            this.TextBoxShutdownTimer.TabIndex = 6;
            this.TextBoxShutdownTimer.Text = resources.GetString("TextBoxShutdownTimer.Text");
            this.TextBoxShutdownTimer.TextChanged += new System.EventHandler(this.TextBoxShutdownTimer_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minuts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hours";
            // 
            // MinutsBox
            // 
            this.MinutsBox.Location = new System.Drawing.Point(172, 211);
            this.MinutsBox.Name = "MinutsBox";
            this.MinutsBox.Size = new System.Drawing.Size(72, 20);
            this.MinutsBox.TabIndex = 2;
            this.MinutsBox.ValueChanged += new System.EventHandler(this.MinutsBox_ValueChanged);
            // 
            // SecondsBox
            // 
            this.SecondsBox.Location = new System.Drawing.Point(259, 211);
            this.SecondsBox.Name = "SecondsBox";
            this.SecondsBox.Size = new System.Drawing.Size(72, 20);
            this.SecondsBox.TabIndex = 1;
            this.SecondsBox.ValueChanged += new System.EventHandler(this.SecondsBox_ValueChanged);
            // 
            // HoursBox
            // 
            this.HoursBox.Location = new System.Drawing.Point(85, 211);
            this.HoursBox.Name = "HoursBox";
            this.HoursBox.Size = new System.Drawing.Size(72, 20);
            this.HoursBox.TabIndex = 0;
            this.HoursBox.ValueChanged += new System.EventHandler(this.HoursBox_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 604);
            this.Controls.Add(this.ShutdownTimerPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ShutdownTimerPanel.ResumeLayout(false);
            this.RestartTimerPanel.ResumeLayout(false);
            this.RestartTimerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinutsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shutdownComandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutdownNowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutdownOnTimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelShutdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartComandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartNowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartOnTimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelRestartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveFilesFromSubToParentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forceMoveFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyFilesFromSubToParrentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forceCopyFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forceDeletFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllFilesInDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diskParttitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startDiskPartitionCmdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installWebserviceInEclipseToolStripMenuItem;
        private System.Windows.Forms.Panel ShutdownTimerPanel;
        private System.Windows.Forms.RichTextBox TextBoxShutdownTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown MinutsBox;
        private System.Windows.Forms.NumericUpDown SecondsBox;
        private System.Windows.Forms.NumericUpDown HoursBox;
        private System.Windows.Forms.Button ShutdownTimerExecute;
        private System.Windows.Forms.Panel RestartTimerPanel;
    }
}

