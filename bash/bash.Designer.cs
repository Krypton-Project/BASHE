namespace bash
{
    partial class bashGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bashGUI));
            this.formToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.bottomFrame = new System.Windows.Forms.StatusStrip();
            this.frame = new System.Windows.Forms.MenuStrip();
            this.closeWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizeWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.bashEmulatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.licenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shell1 = new bash.shell();
            this.frame.SuspendLayout();
            this.SuspendLayout();
            // 
            // formToolTip
            // 
            this.formToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.formToolTip.ToolTipTitle = "Bash Emulator";
            // 
            // bottomFrame
            // 
            this.bottomFrame.BackgroundImage = global::bash.Properties.Resources.gradient1;
            this.bottomFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bottomFrame.Location = new System.Drawing.Point(0, 371);
            this.bottomFrame.Name = "bottomFrame";
            this.bottomFrame.Size = new System.Drawing.Size(587, 22);
            this.bottomFrame.TabIndex = 1;
            this.bottomFrame.Text = "statusStrip1";
            // 
            // frame
            // 
            this.frame.AutoSize = false;
            this.frame.BackColor = System.Drawing.Color.Silver;
            this.frame.BackgroundImage = global::bash.Properties.Resources.gradient1;
            this.frame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frame.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeWindow,
            this.maximizeWindow,
            this.minimizeWindow,
            this.bashEmulatorToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripSeparator1,
            this.fileToolStripMenuItem,
            this.helpItem});
            this.frame.Location = new System.Drawing.Point(0, 0);
            this.frame.Name = "frame";
            this.frame.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.frame.Size = new System.Drawing.Size(587, 39);
            this.frame.TabIndex = 0;
            this.frame.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.frame_MouseDoubleClick);
            this.frame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frame_MouseDown);
            // 
            // closeWindow
            // 
            this.closeWindow.BackColor = System.Drawing.Color.Transparent;
            this.closeWindow.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeWindow.ForeColor = System.Drawing.Color.White;
            this.closeWindow.Name = "closeWindow";
            this.closeWindow.Size = new System.Drawing.Size(30, 35);
            this.closeWindow.Text = "&X";
            this.closeWindow.ToolTipText = "Exit Bash Emulator";
            this.closeWindow.Click += new System.EventHandler(this.closeWindow_Click);
            // 
            // maximizeWindow
            // 
            this.maximizeWindow.BackColor = System.Drawing.Color.Transparent;
            this.maximizeWindow.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximizeWindow.ForeColor = System.Drawing.Color.White;
            this.maximizeWindow.Name = "maximizeWindow";
            this.maximizeWindow.Size = new System.Drawing.Size(31, 35);
            this.maximizeWindow.Text = "+";
            this.maximizeWindow.Click += new System.EventHandler(this.maximizeWindow_Click);
            // 
            // minimizeWindow
            // 
            this.minimizeWindow.BackColor = System.Drawing.Color.Transparent;
            this.minimizeWindow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeWindow.ForeColor = System.Drawing.Color.White;
            this.minimizeWindow.Name = "minimizeWindow";
            this.minimizeWindow.Size = new System.Drawing.Size(26, 35);
            this.minimizeWindow.Text = "-";
            this.minimizeWindow.Click += new System.EventHandler(this.minimizeWindow_Click);
            // 
            // bashEmulatorToolStripMenuItem
            // 
            this.bashEmulatorToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bashEmulatorToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.bashEmulatorToolStripMenuItem.Image = global::bash.Properties.Resources.window_icon;
            this.bashEmulatorToolStripMenuItem.Name = "bashEmulatorToolStripMenuItem";
            this.bashEmulatorToolStripMenuItem.Size = new System.Drawing.Size(193, 35);
            this.bashEmulatorToolStripMenuItem.Text = "Bash Emulator Alpha 1";
            this.bashEmulatorToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bashEmulatorToolStripMenuItem.ToolTipText = "BASH (Bourne Again Shell) Windows emulator.";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator8,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 35);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(149, 6);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpItem
            // 
            this.helpItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripSeparator3,
            this.licenseToolStripMenuItem});
            this.helpItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpItem.ForeColor = System.Drawing.Color.White;
            this.helpItem.Name = "helpItem";
            this.helpItem.Size = new System.Drawing.Size(48, 35);
            this.helpItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.aboutToolStripMenuItem.Text = "About  ...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(136, 6);
            // 
            // licenseToolStripMenuItem
            // 
            this.licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            this.licenseToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.licenseToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.licenseToolStripMenuItem.Text = "License";
            this.licenseToolStripMenuItem.Click += new System.EventHandler(this.licenseToolStripMenuItem_Click);
            // 
            // shell1
            // 
            this.shell1.BackColor = System.Drawing.Color.White;
            this.shell1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shell1.Location = new System.Drawing.Point(0, 39);
            this.shell1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shell1.Name = "shell1";
            this.shell1.Size = new System.Drawing.Size(587, 332);
            this.shell1.TabIndex = 2;
            // 
            // bashGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 393);
            this.Controls.Add(this.shell1);
            this.Controls.Add(this.bottomFrame);
            this.Controls.Add(this.frame);
            this.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.frame;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "bashGUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.frame.ResumeLayout(false);
            this.frame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip frame;
        private System.Windows.Forms.ToolStripMenuItem closeWindow;
        private System.Windows.Forms.StatusStrip bottomFrame;
        private System.Windows.Forms.ToolTip formToolTip;
        private System.Windows.Forms.ToolStripMenuItem maximizeWindow;
        private System.Windows.Forms.ToolStripMenuItem bashEmulatorToolStripMenuItem;
        private shell shell1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem minimizeWindow;
    }
}

