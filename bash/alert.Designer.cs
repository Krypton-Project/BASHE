namespace bash
{
    partial class alert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alert));
            this.frame = new System.Windows.Forms.MenuStrip();
            this.closeWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.titleStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.body = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.icon = new System.Windows.Forms.PictureBox();
            this.frame.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // frame
            // 
            this.frame.AutoSize = false;
            this.frame.BackColor = System.Drawing.Color.Silver;
            this.frame.BackgroundImage = global::bash.Properties.Resources.gradient1;
            this.frame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frame.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeWindow,
            this.titleStrip});
            this.frame.Location = new System.Drawing.Point(0, 0);
            this.frame.Name = "frame";
            this.frame.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.frame.Size = new System.Drawing.Size(411, 39);
            this.frame.TabIndex = 1;
            this.frame.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.frame_ItemClicked);
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
            // titleStrip
            // 
            this.titleStrip.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.titleStrip.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.titleStrip.Image = global::bash.Properties.Resources.alert;
            this.titleStrip.Name = "titleStrip";
            this.titleStrip.Size = new System.Drawing.Size(94, 35);
            this.titleStrip.Text = "Warning";
            this.titleStrip.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.body);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(77, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Warning";
            // 
            // body
            // 
            this.body.BackColor = System.Drawing.SystemColors.Control;
            this.body.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.body.Location = new System.Drawing.Point(18, 28);
            this.body.Multiline = true;
            this.body.Name = "body";
            this.body.ReadOnly = true;
            this.body.Size = new System.Drawing.Size(280, 63);
            this.body.TabIndex = 0;
            // 
            // ok
            // 
            this.ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ok.Location = new System.Drawing.Point(300, 148);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(98, 33);
            this.ok.TabIndex = 3;
            this.ok.Text = "&OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // icon
            // 
            this.icon.Image = global::bash.Properties.Resources.alert;
            this.icon.Location = new System.Drawing.Point(5, 42);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(67, 65);
            this.icon.TabIndex = 1;
            this.icon.TabStop = false;
            // 
            // alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 185);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.frame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "alert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.alert_Load);
            this.frame.ResumeLayout(false);
            this.frame.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip frame;
        private System.Windows.Forms.ToolStripMenuItem closeWindow;
        private System.Windows.Forms.ToolStripMenuItem titleStrip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox body;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.PictureBox icon;
    }
}