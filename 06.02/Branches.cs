using System;
using System.Windows.Forms;

namespace _06._02
{
    public partial class Branches : Form
    {
        public Branches()
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
            Result.Clear();
            cosX.Checked = false;
            sqrX.Checked = false;
            expX.Checked = false;
            Result.Text = "Готов работать!";
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            Result.Clear();
            if (WriteX.Text == "" || WriteY.Text == "")
            {
                MessageBox.Show("Please, Enter any Meanings!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double X = Convert.ToDouble(WriteX.Text);
                double Y = Convert.ToDouble(WriteY.Text);
                if (!cosX.Checked && !sqrX.Checked && !expX.Checked)
                {
                    MessageBox.Show("U need to choose radiobutton!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (X / Y > 0)
                    {
                        if (cosX.Checked)
                        {
                            double CosX = Math.Cos(X);
                            double Result1 = Math.Log(Y + 2) + CosX;
                            Result.Text = $"Ответ = {Result1}";
                        }
                        else if (sqrX.Checked)
                        {
                            double sqrX = Math.Sqrt(X);
                            double Result2 = Math.Log(Y + 2) + sqrX;
                            Result.Text = $"Ответ = {Result2}";
                        }
                        else if (expX.Checked)
                        {
                            double ExpX = Math.Exp(X);
                            double Result3 = Math.Log(Y + 2) + ExpX;
                            Result.Text = $"Ответ = {Result3}";
                        }
                    }
                    else if (X / Y < 0)
                    {
                        if (cosX.Checked)
                        {
                            double CosX = Math.Cos(X);
                            double Result4 = Math.Log(Math.Abs(Y)) - Math.Tan(CosX);
                            Result.Text = $"Ответ = {Result4}";
                        }
                        else if (sqrX.Checked)
                        {
                            double sqrX = Math.Sqrt(X);
                            double Result5 = Math.Log(Math.Abs(Y)) - Math.Tan(sqrX);
                            Result.Text = $"Ответ = {Result5}";
                        }
                        else if (expX.Checked)
                        {
                            double ExpX = Math.Exp(X);
                            double Result6 = Math.Log(Math.Abs(Y)) - Math.Tan(ExpX);
                            Result.Text = $"Ответ = {Result6}";
                        }
                    }
                    else
                    {
                        if (cosX.Checked)
                        {
                            double CosX = Math.Cos(X);
                            double Result7 = CosX * Math.Pow(Y, 3);
                            Result.Text = $"Ответ = {Result7}";
                        }
                        else if (sqrX.Checked)
                        {
                            double sqrX = Math.Sqrt(X);
                            double Result8 = sqrX * Math.Pow(Y, 3);
                            Result.Text = $"Ответ = {Result8}";
                        }
                        else if (expX.Checked)
                        {
                            double ExpX = Math.Exp(X);
                            double Result9 = ExpX * Math.Pow(Y, 3);
                            Result.Text = $"Ответ = {Result9}";
                        }
                    }
                }
            }
        }
    }
}
