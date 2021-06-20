using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_FormViaDesigner
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            label1.Text = label2.Text = label3.Text = String.Empty;
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formHelp = new Help();
            var result = formHelp.ShowDialog();
            if(result == DialogResult.Cancel)
            {
                this.Show();
            }
        }
    }
}
