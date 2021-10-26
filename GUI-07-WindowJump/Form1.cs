using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI_07_WindowJump
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTopLeft_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }

        private void buttonTopRight_Click(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);
        }

        private void buttonBottomLeft_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
        }

        private void buttonBottomRight_Click(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
        }
    }
}