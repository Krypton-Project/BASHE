using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace bash
{
    public partial class alert : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;        
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public alert()
        {
            InitializeComponent();
        }

        private void alert_Load(object sender, EventArgs e)
        {
            /* Nothing to see here */
            ok.Select();
        }

        private void frame_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public static void message(string message, string frameTxt, string title)
        {            
            alert xwindow = new alert();
            xwindow.body.Text = message;
            xwindow.body.CanSelect.Equals(false);
            xwindow.groupBox1.Text = frameTxt;
            xwindow.titleStrip.Text = title;
            xwindow.ShowDialog();
        }

        private void frame_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 100);

            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
