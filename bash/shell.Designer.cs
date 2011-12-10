namespace bash
{
    partial class shell
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.send = new System.Windows.Forms.Button();
            this.terminal = new System.Windows.Forms.RichTextBox();
            this.command = new System.Windows.Forms.TextBox();
            this.table.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.ColumnCount = 1;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table.Controls.Add(this.panel1, 0, 0);
            this.table.Controls.Add(this.command, 0, 1);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 2;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.61702F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.382979F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.Size = new System.Drawing.Size(522, 282);
            this.table.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.send);
            this.panel1.Controls.Add(this.terminal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 257);
            this.panel1.TabIndex = 0;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(438, 219);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(10, 10);
            this.send.TabIndex = 1;
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // terminal
            // 
            this.terminal.BackColor = System.Drawing.Color.Silver;
            this.terminal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.terminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.terminal.Location = new System.Drawing.Point(0, 0);
            this.terminal.Name = "terminal";
            this.terminal.ReadOnly = true;
            this.terminal.Size = new System.Drawing.Size(516, 257);
            this.terminal.TabIndex = 0;
            this.terminal.Text = "";          
            // 
            // command
            // 
            this.command.Dock = System.Windows.Forms.DockStyle.Fill;
            this.command.Location = new System.Drawing.Point(3, 266);
            this.command.Multiline = true;
            this.command.Name = "command";
            this.command.Size = new System.Drawing.Size(516, 13);
            this.command.TabIndex = 1;
            // 
            // shell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.table);
            this.Name = "shell";
            this.Size = new System.Drawing.Size(522, 282);
            this.Load += new System.EventHandler(this.shell_Load);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox command;
        public System.Windows.Forms.Button send;
        public System.Windows.Forms.RichTextBox terminal;
    }
}
