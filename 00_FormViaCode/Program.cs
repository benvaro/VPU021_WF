using System;
using System.Drawing;
using System.Windows.Forms;

namespace _00_FormViaCode
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MessageBox
            //var dialogResult = MessageBox.Show("Hello", "First window", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            //    switch (dialogResult)
            //{
            //    case DialogResult.Cancel:
            //        Console.WriteLine("User press cancel");
            //        break;
            //    case DialogResult.Yes:
            //        ShowForm();
            //        break;
            //    case DialogResult.No:
            //        Console.WriteLine("User press no");
            //        break;
            //} 
            #endregion

            ShowForm();
        }

        private static void ShowForm()
        {
            var form = new Form();

            form.BackColor = Color.LightBlue;
            form.ForeColor = Color.Coral;
            form.Width = 400;
            form.Height = 400;
            form.Font = new Font("Impact", 16);
            form.Text = "My first form";

            var label = new Label();
            label.Text = "Sunday, 20 June";
            label.AutoSize = true;
            label.Location = new Point(form.ClientSize.Width / 2 - label.Width / 2, form.ClientSize.Height / 2 - label.Height / 2);

            var button = new Button();
            button.Text = "Press me";
            button.Font = new Font(form.Font.FontFamily, 12, FontStyle.Italic);
            button.ForeColor = Color.FromArgb(100, 34, 200);
            button.BackColor = Color.FromName("Orange");
            button.Width = 100;
            button.Height = 40;
            button.Click += Button_Click;

            form.Controls.Add(label);
            form.Controls.Add(button);

            form.ShowDialog();
        }

        static bool isClicked = false;

        // При натисненні кнопки - змінюємо фон кнопки
        private static void Button_Click(object sender, EventArgs e)
        {
            isClicked = !isClicked; // ?
            var obj = (sender as Button);

            // Parent - властивість елемента, що містить "батьківський" елемент
            // наступний рядок змінить фон форми
            obj.Parent.BackColor = isClicked ? Color.Red : Color.Orange;
            //obj.BackColor = isClicked ? Color.Red : Color.Orange; 
        }
    }
}
