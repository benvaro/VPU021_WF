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
            //timer1.Enabled = true;  // запустити таймер 1 спосіб
            timer1.Start();  // запустити таймер - другий спосіб
        }

        // обробник події Tick: спрацьовує щосекунди в нашому випадку, (раз/на інтервал, що вказаний в timer.Interval)
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = $"{++time} s";
        }

        // Клік мишкою по лейбі
        private void lblInfo_MouseClick(object sender, MouseEventArgs e) // MouseEventArgs: спеціальні аргументи мишки, ми можемо отримати інформацію про клік
        {
            this.Text = $"Clicked: ({e.X}; {e.Y})"; // e.X, e.Y - координати мишки, де відбувся клік
            if(e.Button == MouseButtons.Right) // якщо клікнули правою кнопкою мишки
            {
                lblInfo.BackColor = Color.Magenta;
            }
            else
            {
                lblInfo.BackColor = Color.LightSlateGray;
            }

            lblInfo.Text = "Mouse click";
        }

        // Подвійний клік мишкою по формі
        private void form_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // створюємо нову лейбу
            var label = new Label();
            label.BackColor = Color.Green;
            label.Width = label.Height = 20;
            label.BorderStyle = BorderStyle.Fixed3D;
            label.Location = new Point(e.X, e.Y);

            // додаємо в колекцію контролів на формі
            this.Controls.Add(label); 
        }

        // відбувається першою, коли елемент отримує фокус мишки (курсор)
        private void Help_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Text = "Mouse enter";
            lblInfo.BackColor = Color.Red;
        }

        // коли курсор мишки знаходиться НАД елементом (в нашому випадку формою)
        private void Help_MouseHover(object sender, EventArgs e)
        {
            // Thread.Sleep(1000);
            lblInfo.Text = "Mouse hover";
            lblInfo.BackColor = Color.Green;
        }

        // коли курсор мишки покидає область
        private void Help_MouseLeave(object sender, EventArgs e)
        {
            lblInfo.Text = "Mouse leave";
            lblInfo.BackColor = Color.Blue;
        }
    }
}
