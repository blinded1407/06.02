using System;
using System.Windows.Forms;

namespace _06._02
{
    public partial class Line : Form
    {
        public Line()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.Sizable;
            Result.ReadOnly = true;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            WriteX.Clear();
            WriteY.Clear();
            WriteZ.Clear();
            Result.Clear();
            Result.Text = "Готов работать!";
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            Result.Clear();
            if (WriteX.Text == "" || WriteY.Text == "" || WriteZ.Text == "")
            {
                MessageBox.Show("Please, Enter any Meanings!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double X = Convert.ToDouble(WriteX.Text);
                double Y = Convert.ToDouble(WriteY.Text);
                double Z = Convert.ToDouble(WriteZ.Text);
                double Result1 = 1 + Math.Pow(Z, 2) / (3 - (Math.Pow(Z, 2) / 5)) * (2 * Math.Cos(X - (Math.PI / 6)) / (0.5 + Math.Pow(Math.Sin(Y), 2))); 
                Result.Text = $"Ответ = {Result1}";
            }
        }
    }
}
