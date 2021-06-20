using System;
using System.Drawing;
using System.Windows.Forms;

namespace _01_FormViaDesigner
{
    public partial class Help : Form
    {
        private int time = 0;
        public Help()
        {
            InitializeComponent();
            //timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = $"{++time} s";
        }

        // Клік мишкою по лейбі
        private void lblInfo_MouseClick(object sender, MouseEventArgs e)
        {
            this.Text = $"Clicked: ({e.X}; {e.Y})";
            if(e.Button == MouseButtons.Right)
            {
                lblInfo.BackColor = Color.Magenta;
            }
            else
            {
                lblInfo.BackColor = Color.LightSlateGray;
            }

            lblInfo.Text = "Mouse click";
        }

        private void lblInfo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var label = new Label();
            label.BackColor = Color.Green;
            label.Width = label.Height = 20;
            label.BorderStyle = BorderStyle.Fixed3D;
            label.Location = new Point(e.X, e.Y);

            this.Controls.Add(label);
        }

        private void Help_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Text = "Mouse enter";
            lblInfo.BackColor = Color.Red;
        }

        private void Help_MouseHover(object sender, EventArgs e)
        {
            // Thread.Sleep(1000);
            lblInfo.Text = "Mouse hover";
            lblInfo.BackColor = Color.Green;
        }

        private void Help_MouseLeave(object sender, EventArgs e)
        {
            lblInfo.Text = "Mouse leave";
            lblInfo.BackColor = Color.Blue;
        }
    }
}
