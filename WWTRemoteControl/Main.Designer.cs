namespace WWTRemoteControl
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.wwtNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.launchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.launchAll = new System.Windows.Forms.Button();
            this.killAll = new System.Windows.Forms.Button();
            this.runCommand = new System.Windows.Forms.Button();
            this.commandText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wakeAll = new System.Windows.Forms.Button();
            this.nodeList = new System.Windows.Forms.Button();
            this.shutdownAll = new System.Windows.Forms.Button();
            this.RestartAll = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.WatchDog = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.netID = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Landscape0 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Portrait270 = new System.Windows.Forms.Button();
            this.UpsideDown180 = new System.Windows.Forms.Button();
            this.Portrait90 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gammaValueB = new System.Windows.Forms.TextBox();
            this.gammaValueA = new System.Windows.Forms.TextBox();
            this.gammaB = new System.Windows.Forms.Button();
            this.gammaA = new System.Windows.Forms.Button();
            this.WatchDogTimer = new System.Windows.Forms.Timer(this.components);
            this.MasterCheckbox = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // wwtNotify
            // 
            this.wwtNotify.BalloonTipText = "WWT Remote Controler";
            this.wwtNotify.ContextMenuStrip = this.contextMenuStrip1;
            this.wwtNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("wwtNotify.Icon")));
            this.wwtNotify.Text = "WWT Remote Control";
            this.wwtNotify.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.toolStripMenuItem1,
            this.launchToolStripMenuItem,
            this.killToolStripMenuItem,
            this.toolStripMenuItem2,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(239, 136);
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.masterToolStripMenuItem.Text = "Control Panel";
            this.masterToolStripMenuItem.Click += new System.EventHandler(this.masterToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(235, 6);
            // 
            // launchToolStripMenuItem
            // 
            this.launchToolStripMenuItem.Name = "launchToolStripMenuItem";
            this.launchToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.launchToolStripMenuItem.Text = "Launch WWT (local)";
            this.launchToolStripMenuItem.Click += new System.EventHandler(this.launchToolStripMenuItem_Click);
            // 
            // killToolStripMenuItem
            // 
            this.killToolStripMenuItem.Name = "killToolStripMenuItem";
            this.killToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.killToolStripMenuItem.Text = "Close WWT (local)";
            this.killToolStripMenuItem.Click += new System.EventHandler(this.killToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(235, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // launchAll
            // 
            this.launchAll.Location = new System.Drawing.Point(30, 29);
            this.launchAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.launchAll.Name = "launchAll";
            this.launchAll.Size = new System.Drawing.Size(170, 40);
            this.launchAll.TabIndex = 1;
            this.launchAll.Text = "Launch All";
            this.launchAll.UseVisualStyleBackColor = true;
            this.launchAll.Click += new System.EventHandler(this.launchAll_Click);
            // 
            // killAll
            // 
            this.killAll.Location = new System.Drawing.Point(30, 74);
            this.killAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.killAll.Name = "killAll";
            this.killAll.Size = new System.Drawing.Size(170, 40);
            this.killAll.TabIndex = 2;
            this.killAll.Text = "Close All";
            this.killAll.UseVisualStyleBackColor = true;
            this.killAll.Click += new System.EventHandler(this.killAll_Click);
            // 
            // runCommand
            // 
            this.runCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.runCommand.Location = new System.Drawing.Point(758, 309);
            this.runCommand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.runCommand.Name = "runCommand";
            this.runCommand.Size = new System.Drawing.Size(170, 35);
            this.runCommand.TabIndex = 3;
            this.runCommand.Text = "Run Command";
            this.runCommand.UseVisualStyleBackColor = true;
            this.runCommand.Click += new System.EventHandler(this.runCommand_Click);
            // 
            // commandText
            // 
            this.commandText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandText.Location = new System.Drawing.Point(18, 269);
            this.commandText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.commandText.Name = "commandText";
            this.commandText.Size = new System.Drawing.Size(907, 26);
            this.commandText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 245);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type Command Below";
            // 
            // wakeAll
            // 
            this.wakeAll.Location = new System.Drawing.Point(42, 29);
            this.wakeAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wakeAll.Name = "wakeAll";
            this.wakeAll.Size = new System.Drawing.Size(140, 35);
            this.wakeAll.TabIndex = 6;
            this.wakeAll.Text = "Wake All";
            this.wakeAll.UseVisualStyleBackColor = true;
            this.wakeAll.Click += new System.EventHandler(this.wakeAll_Click);
            // 
            // nodeList
            // 
            this.nodeList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nodeList.Location = new System.Drawing.Point(18, 309);
            this.nodeList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nodeList.Name = "nodeList";
            this.nodeList.Size = new System.Drawing.Size(112, 35);
            this.nodeList.TabIndex = 7;
            this.nodeList.Text = "Node List";
            this.nodeList.UseVisualStyleBackColor = true;
            this.nodeList.Click += new System.EventHandler(this.nodeList_Click);
            // 
            // shutdownAll
            // 
            this.shutdownAll.Location = new System.Drawing.Point(42, 74);
            this.shutdownAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shutdownAll.Name = "shutdownAll";
            this.shutdownAll.Size = new System.Drawing.Size(140, 35);
            this.shutdownAll.TabIndex = 2;
            this.shutdownAll.Text = "Shutdown All";
            this.shutdownAll.UseVisualStyleBackColor = true;
            this.shutdownAll.Click += new System.EventHandler(this.shutdownAll_Click);
            // 
            // RestartAll
            // 
            this.RestartAll.Location = new System.Drawing.Point(42, 123);
            this.RestartAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RestartAll.Name = "RestartAll";
            this.RestartAll.Size = new System.Drawing.Size(140, 35);
            this.RestartAll.TabIndex = 2;
            this.RestartAll.Text = "Restart All";
            this.RestartAll.UseVisualStyleBackColor = true;
            this.RestartAll.Click += new System.EventHandler(this.RestartAll_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(30, 123);
            this.Update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(170, 35);
            this.Update.TabIndex = 8;
            this.Update.Text = "Update Software";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Visible = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wakeAll);
            this.groupBox1.Controls.Add(this.RestartAll);
            this.groupBox1.Controls.Add(this.shutdownAll);
            this.groupBox1.Location = new System.Drawing.Point(273, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(206, 214);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Machine Control";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.WatchDog);
            this.groupBox2.Controls.Add(this.killAll);
            this.groupBox2.Controls.Add(this.launchAll);
            this.groupBox2.Controls.Add(this.Update);
            this.groupBox2.Location = new System.Drawing.Point(18, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(231, 214);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "WWT Processes";
            // 
            // WatchDog
            // 
            this.WatchDog.AutoSize = true;
            this.WatchDog.Location = new System.Drawing.Point(50, 174);
            this.WatchDog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WatchDog.Name = "WatchDog";
            this.WatchDog.Size = new System.Drawing.Size(115, 24);
            this.WatchDog.TabIndex = 9;
            this.WatchDog.Text = "Watch Dog";
            this.WatchDog.UseVisualStyleBackColor = true;
            this.WatchDog.CheckedChanged += new System.EventHandler(this.WatchDog_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 317);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "NetID";
            // 
            // netID
            // 
            this.netID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.netID.Location = new System.Drawing.Point(201, 312);
            this.netID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.netID.Name = "netID";
            this.netID.ReadOnly = true;
            this.netID.Size = new System.Drawing.Size(79, 26);
            this.netID.TabIndex = 12;
            this.netID.Text = "0";
            this.toolTip1.SetToolTip(this.netID, "Double Click this field to Edit Network ID");
            this.netID.TextChanged += new System.EventHandler(this.netID_TextChanged);
            this.netID.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.netID_MouseDoubleClick);
            // 
            // Landscape0
            // 
            this.Landscape0.Location = new System.Drawing.Point(22, 29);
            this.Landscape0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Landscape0.Name = "Landscape0";
            this.Landscape0.Size = new System.Drawing.Size(140, 35);
            this.Landscape0.TabIndex = 7;
            this.Landscape0.Text = "Landscape 0";
            this.Landscape0.UseVisualStyleBackColor = true;
            this.Landscape0.Click += new System.EventHandler(this.Landscape0_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Portrait270);
            this.groupBox3.Controls.Add(this.UpsideDown180);
            this.groupBox3.Controls.Add(this.Portrait90);
            this.groupBox3.Controls.Add(this.Landscape0);
            this.groupBox3.Location = new System.Drawing.Point(501, 18);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(206, 214);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Orientation";
            // 
            // Portrait270
            // 
            this.Portrait270.Location = new System.Drawing.Point(22, 163);
            this.Portrait270.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Portrait270.Name = "Portrait270";
            this.Portrait270.Size = new System.Drawing.Size(140, 35);
            this.Portrait270.TabIndex = 7;
            this.Portrait270.Text = "Portrait 270";
            this.Portrait270.UseVisualStyleBackColor = true;
            this.Portrait270.Click += new System.EventHandler(this.Portrait270_Click);
            // 
            // UpsideDown180
            // 
            this.UpsideDown180.Location = new System.Drawing.Point(22, 118);
            this.UpsideDown180.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpsideDown180.Name = "UpsideDown180";
            this.UpsideDown180.Size = new System.Drawing.Size(140, 35);
            this.UpsideDown180.TabIndex = 7;
            this.UpsideDown180.Text = "Upside Down";
            this.UpsideDown180.UseVisualStyleBackColor = true;
            this.UpsideDown180.Click += new System.EventHandler(this.UpsideDown180_Click);
            // 
            // Portrait90
            // 
            this.Portrait90.Location = new System.Drawing.Point(22, 74);
            this.Portrait90.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Portrait90.Name = "Portrait90";
            this.Portrait90.Size = new System.Drawing.Size(140, 35);
            this.Portrait90.TabIndex = 7;
            this.Portrait90.Text = "Portrait 90";
            this.Portrait90.UseVisualStyleBackColor = true;
            this.Portrait90.Click += new System.EventHandler(this.Portrait90_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.gammaValueB);
            this.groupBox4.Controls.Add(this.gammaValueA);
            this.groupBox4.Controls.Add(this.gammaB);
            this.groupBox4.Controls.Add(this.gammaA);
            this.groupBox4.Location = new System.Drawing.Point(722, 18);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(206, 214);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gamma Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "gamma B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "gamma A";
            // 
            // gammaValueB
            // 
            this.gammaValueB.Location = new System.Drawing.Point(112, 166);
            this.gammaValueB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gammaValueB.Name = "gammaValueB";
            this.gammaValueB.Size = new System.Drawing.Size(64, 26);
            this.gammaValueB.TabIndex = 1;
            this.gammaValueB.Validating += new System.ComponentModel.CancelEventHandler(this.gammaValueB_Validating);
            this.gammaValueB.Validated += new System.EventHandler(this.gammaValueB_Validated);
            // 
            // gammaValueA
            // 
            this.gammaValueA.Location = new System.Drawing.Point(112, 74);
            this.gammaValueA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gammaValueA.Name = "gammaValueA";
            this.gammaValueA.Size = new System.Drawing.Size(64, 26);
            this.gammaValueA.TabIndex = 1;
            this.gammaValueA.Validating += new System.ComponentModel.CancelEventHandler(this.gammaValueA_Validating);
            this.gammaValueA.Validated += new System.EventHandler(this.gammaValueA_Validated);
            // 
            // gammaB
            // 
            this.gammaB.Location = new System.Drawing.Point(9, 118);
            this.gammaB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gammaB.Name = "gammaB";
            this.gammaB.Size = new System.Drawing.Size(170, 35);
            this.gammaB.TabIndex = 0;
            this.gammaB.Text = "Set Gamma B";
            this.gammaB.UseVisualStyleBackColor = true;
            this.gammaB.Click += new System.EventHandler(this.gammaB_Click);
            // 
            // gammaA
            // 
            this.gammaA.Location = new System.Drawing.Point(9, 29);
            this.gammaA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gammaA.Name = "gammaA";
            this.gammaA.Size = new System.Drawing.Size(170, 35);
            this.gammaA.TabIndex = 0;
            this.gammaA.Text = "Set Gamma A";
            this.gammaA.UseVisualStyleBackColor = true;
            this.gammaA.Click += new System.EventHandler(this.gammaA_Click);
            // 
            // WatchDogTimer
            // 
            this.WatchDogTimer.Enabled = true;
            this.WatchDogTimer.Interval = 5000;
            this.WatchDogTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MasterCheckbox
            // 
            this.MasterCheckbox.AutoSize = true;
            this.MasterCheckbox.Location = new System.Drawing.Point(315, 315);
            this.MasterCheckbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MasterCheckbox.Name = "MasterCheckbox";
            this.MasterCheckbox.Size = new System.Drawing.Size(279, 24);
            this.MasterCheckbox.TabIndex = 14;
            this.MasterCheckbox.Text = "This machine should act as master";
            this.MasterCheckbox.UseVisualStyleBackColor = true;
            this.MasterCheckbox.CheckedChanged += new System.EventHandler(this.MasterCheckbox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 349);
            this.Controls.Add(this.MasterCheckbox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.netID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.nodeList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commandText);
            this.Controls.Add(this.runCommand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.Text = "WWT Remote Control";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon wwtNotify;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem launchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem killToolStripMenuItem;
        private System.Windows.Forms.Button launchAll;
        private System.Windows.Forms.Button killAll;
        private System.Windows.Forms.Button runCommand;
        private System.Windows.Forms.TextBox commandText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.Button wakeAll;
        private System.Windows.Forms.Button nodeList;
        private System.Windows.Forms.Button shutdownAll;
        private System.Windows.Forms.Button RestartAll;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox netID;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button Landscape0;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Portrait270;
        private System.Windows.Forms.Button UpsideDown180;
        private System.Windows.Forms.Button Portrait90;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gammaValueB;
        private System.Windows.Forms.TextBox gammaValueA;
        private System.Windows.Forms.Button gammaB;
        private System.Windows.Forms.Button gammaA;
        private System.Windows.Forms.Timer WatchDogTimer;
        private System.Windows.Forms.CheckBox WatchDog;
        private System.Windows.Forms.CheckBox MasterCheckbox;
    }
}

