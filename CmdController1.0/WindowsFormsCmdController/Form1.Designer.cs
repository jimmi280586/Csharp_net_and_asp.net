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
            this.ShutdownTimerPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxShutdownTimer = new System.Windows.Forms.RichTextBox();
            this.ShutdownTimerExecute = new System.Windows.Forms.Button();
            this.HoursBox = new System.Windows.Forms.NumericUpDown();
            this.MinutsBox = new System.Windows.Forms.NumericUpDown();
            this.SecondsBox = new System.Windows.Forms.NumericUpDown();
            this.restartOnTimerPanel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.restartTextBox = new System.Windows.Forms.TextBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.executeRestart = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.diskpartPanel = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.rootPath = new System.Windows.Forms.TextBox();
            this.destinationPath = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.destFolderCopy = new System.Windows.Forms.TextBox();
            this.rootFolderCopy = new System.Windows.Forms.TextBox();
            this.ShutdownTimerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoursBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsBox)).BeginInit();
            this.restartOnTimerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.diskpartPanel.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShutdownTimerPanel
            // 
            this.ShutdownTimerPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ShutdownTimerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShutdownTimerPanel.Controls.Add(this.button2);
            this.ShutdownTimerPanel.Controls.Add(this.button1);
            this.ShutdownTimerPanel.Controls.Add(this.label1);
            this.ShutdownTimerPanel.Controls.Add(this.label2);
            this.ShutdownTimerPanel.Controls.Add(this.label3);
            this.ShutdownTimerPanel.Controls.Add(this.TextBoxShutdownTimer);
            this.ShutdownTimerPanel.Controls.Add(this.ShutdownTimerExecute);
            this.ShutdownTimerPanel.Controls.Add(this.HoursBox);
            this.ShutdownTimerPanel.Controls.Add(this.MinutsBox);
            this.ShutdownTimerPanel.Controls.Add(this.SecondsBox);
            this.ShutdownTimerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShutdownTimerPanel.Location = new System.Drawing.Point(3, 3);
            this.ShutdownTimerPanel.Name = "ShutdownTimerPanel";
            this.ShutdownTimerPanel.Size = new System.Drawing.Size(683, 563);
            this.ShutdownTimerPanel.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 489);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 31);
            this.button2.TabIndex = 9;
            this.button2.Text = "Shutdown now";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancel Shutdown";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minuts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seconds";
            // 
            // TextBoxShutdownTimer
            // 
            this.TextBoxShutdownTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxShutdownTimer.Location = new System.Drawing.Point(70, 51);
            this.TextBoxShutdownTimer.Name = "TextBoxShutdownTimer";
            this.TextBoxShutdownTimer.Size = new System.Drawing.Size(529, 118);
            this.TextBoxShutdownTimer.TabIndex = 6;
            this.TextBoxShutdownTimer.Text = resources.GetString("TextBoxShutdownTimer.Text");
            this.TextBoxShutdownTimer.TextChanged += new System.EventHandler(this.TextBoxShutdownTimer_TextChanged);
            // 
            // ShutdownTimerExecute
            // 
            this.ShutdownTimerExecute.Location = new System.Drawing.Point(537, 489);
            this.ShutdownTimerExecute.Name = "ShutdownTimerExecute";
            this.ShutdownTimerExecute.Size = new System.Drawing.Size(122, 32);
            this.ShutdownTimerExecute.TabIndex = 7;
            this.ShutdownTimerExecute.Text = "Shutdown on timer";
            this.ShutdownTimerExecute.UseVisualStyleBackColor = true;
            this.ShutdownTimerExecute.Click += new System.EventHandler(this.ShutdownTimerExecute_Click);
            // 
            // HoursBox
            // 
            this.HoursBox.Location = new System.Drawing.Point(51, 227);
            this.HoursBox.Name = "HoursBox";
            this.HoursBox.Size = new System.Drawing.Size(72, 20);
            this.HoursBox.TabIndex = 0;
            this.HoursBox.ValueChanged += new System.EventHandler(this.HoursBox_ValueChanged);
            // 
            // MinutsBox
            // 
            this.MinutsBox.Location = new System.Drawing.Point(138, 227);
            this.MinutsBox.Name = "MinutsBox";
            this.MinutsBox.Size = new System.Drawing.Size(72, 20);
            this.MinutsBox.TabIndex = 2;
            this.MinutsBox.ValueChanged += new System.EventHandler(this.MinutsBox_ValueChanged);
            // 
            // SecondsBox
            // 
            this.SecondsBox.Location = new System.Drawing.Point(228, 227);
            this.SecondsBox.Name = "SecondsBox";
            this.SecondsBox.Size = new System.Drawing.Size(72, 20);
            this.SecondsBox.TabIndex = 1;
            this.SecondsBox.ValueChanged += new System.EventHandler(this.SecondsBox_ValueChanged);
            // 
            // restartOnTimerPanel
            // 
            this.restartOnTimerPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.restartOnTimerPanel.Controls.Add(this.button4);
            this.restartOnTimerPanel.Controls.Add(this.button3);
            this.restartOnTimerPanel.Controls.Add(this.label6);
            this.restartOnTimerPanel.Controls.Add(this.label5);
            this.restartOnTimerPanel.Controls.Add(this.label4);
            this.restartOnTimerPanel.Controls.Add(this.restartTextBox);
            this.restartOnTimerPanel.Controls.Add(this.numericUpDown3);
            this.restartOnTimerPanel.Controls.Add(this.numericUpDown2);
            this.restartOnTimerPanel.Controls.Add(this.numericUpDown1);
            this.restartOnTimerPanel.Controls.Add(this.executeRestart);
            this.restartOnTimerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.restartOnTimerPanel.Location = new System.Drawing.Point(3, 3);
            this.restartOnTimerPanel.Name = "restartOnTimerPanel";
            this.restartOnTimerPanel.Size = new System.Drawing.Size(683, 563);
            this.restartOnTimerPanel.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(291, 486);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 33);
            this.button4.TabIndex = 9;
            this.button4.Text = "Restart now";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 488);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 31);
            this.button3.TabIndex = 8;
            this.button3.Text = "Cancel restart";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Seconds";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Minuts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hours";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // restartTextBox
            // 
            this.restartTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartTextBox.Location = new System.Drawing.Point(74, 64);
            this.restartTextBox.Multiline = true;
            this.restartTextBox.Name = "restartTextBox";
            this.restartTextBox.Size = new System.Drawing.Size(548, 88);
            this.restartTextBox.TabIndex = 4;
            this.restartTextBox.Text = "To restart on timer please set the timers and press restart on timer If you want " +
    "to cancel the restar you can do this by pressing the cancel restart ";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(289, 201);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown3.TabIndex = 3;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(184, 201);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(76, 20);
            this.numericUpDown2.TabIndex = 2;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(84, 201);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // executeRestart
            // 
            this.executeRestart.Location = new System.Drawing.Point(547, 486);
            this.executeRestart.Name = "executeRestart";
            this.executeRestart.Size = new System.Drawing.Size(103, 34);
            this.executeRestart.TabIndex = 0;
            this.executeRestart.Text = "Restart on timer";
            this.executeRestart.UseVisualStyleBackColor = true;
            this.executeRestart.Click += new System.EventHandler(this.executeRestart_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(0, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(697, 595);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.restartOnTimerPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(689, 569);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Restart";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ShutdownTimerPanel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(689, 569);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Shutdown";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.diskpartPanel);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(689, 569);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DiskPartition";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // diskpartPanel
            // 
            this.diskpartPanel.BackColor = System.Drawing.Color.Red;
            this.diskpartPanel.Controls.Add(this.textBox2);
            this.diskpartPanel.Controls.Add(this.button5);
            this.diskpartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diskpartPanel.Location = new System.Drawing.Point(3, 3);
            this.diskpartPanel.Name = "diskpartPanel";
            this.diskpartPanel.Size = new System.Drawing.Size(683, 563);
            this.diskpartPanel.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(27, 55);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(628, 163);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(503, 493);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 47);
            this.button5.TabIndex = 0;
            this.button5.Text = "Start Disk partition cmd";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DeepPink;
            this.tabPage4.Controls.Add(this.button10);
            this.tabPage4.Controls.Add(this.button9);
            this.tabPage4.Controls.Add(this.button6);
            this.tabPage4.Controls.Add(this.textBox5);
            this.tabPage4.Controls.Add(this.destinationPath);
            this.tabPage4.Controls.Add(this.rootPath);
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(689, 569);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Move";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.DarkViolet;
            this.tabPage5.Controls.Add(this.button11);
            this.tabPage5.Controls.Add(this.button12);
            this.tabPage5.Controls.Add(this.button13);
            this.tabPage5.Controls.Add(this.textBox3);
            this.tabPage5.Controls.Add(this.destFolderCopy);
            this.tabPage5.Controls.Add(this.rootFolderCopy);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(689, 569);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Copy";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.LawnGreen;
            this.tabPage6.Controls.Add(this.textBox1);
            this.tabPage6.Controls.Add(this.tbFilePath);
            this.tabPage6.Controls.Add(this.button8);
            this.tabPage6.Controls.Add(this.button7);
            this.tabPage6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(689, 569);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Delete";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 134);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(611, 150);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(31, 75);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(609, 26);
            this.tbFilePath.TabIndex = 3;
            this.tbFilePath.TextChanged += new System.EventHandler(this.tbFilePath_TextChanged);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(154, 27);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(111, 35);
            this.button8.TabIndex = 2;
            this.button8.Text = "Load file";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(28, 27);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(111, 35);
            this.button7.TabIndex = 1;
            this.button7.Text = "Load folder";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.Cyan;
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(689, 569);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Install webservice";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // rootPath
            // 
            this.rootPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rootPath.Location = new System.Drawing.Point(17, 53);
            this.rootPath.Name = "rootPath";
            this.rootPath.Size = new System.Drawing.Size(427, 20);
            this.rootPath.TabIndex = 0;
            // 
            // destinationPath
            // 
            this.destinationPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationPath.Location = new System.Drawing.Point(18, 92);
            this.destinationPath.Name = "destinationPath";
            this.destinationPath.Size = new System.Drawing.Size(425, 20);
            this.destinationPath.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(20, 153);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(648, 159);
            this.textBox5.TabIndex = 2;
            this.textBox5.Text = resources.GetString("textBox5.Text");
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(537, 53);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 26);
            this.button6.TabIndex = 3;
            this.button6.Text = "Root Folder";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(537, 92);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(106, 26);
            this.button9.TabIndex = 4;
            this.button9.Text = "Destination";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(527, 508);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(116, 40);
            this.button10.TabIndex = 5;
            this.button10.Text = "Start move";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(529, 492);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(116, 40);
            this.button11.TabIndex = 11;
            this.button11.Text = "Start Copy";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(539, 76);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(106, 26);
            this.button12.TabIndex = 10;
            this.button12.Text = "Destination";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(539, 37);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(106, 26);
            this.button13.TabIndex = 9;
            this.button13.Text = "Root Folder";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(22, 137);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(648, 159);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // destFolderCopy
            // 
            this.destFolderCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destFolderCopy.Location = new System.Drawing.Point(19, 80);
            this.destFolderCopy.Name = "destFolderCopy";
            this.destFolderCopy.Size = new System.Drawing.Size(425, 20);
            this.destFolderCopy.TabIndex = 7;
            // 
            // rootFolderCopy
            // 
            this.rootFolderCopy.Location = new System.Drawing.Point(19, 43);
            this.rootFolderCopy.Name = "rootFolderCopy";
            this.rootFolderCopy.Size = new System.Drawing.Size(427, 20);
            this.rootFolderCopy.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 604);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ShutdownTimerPanel.ResumeLayout(false);
            this.ShutdownTimerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoursBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsBox)).EndInit();
            this.restartOnTimerPanel.ResumeLayout(false);
            this.restartOnTimerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.diskpartPanel.ResumeLayout(false);
            this.diskpartPanel.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ShutdownTimerPanel;
        private System.Windows.Forms.Panel restartOnTimerPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox restartTextBox;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button executeRestart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox TextBoxShutdownTimer;
        private System.Windows.Forms.Button ShutdownTimerExecute;
        private System.Windows.Forms.NumericUpDown HoursBox;
        private System.Windows.Forms.NumericUpDown MinutsBox;
        private System.Windows.Forms.NumericUpDown SecondsBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel diskpartPanel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox destinationPath;
        private System.Windows.Forms.TextBox rootPath;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox destFolderCopy;
        private System.Windows.Forms.TextBox rootFolderCopy;
    }
}

