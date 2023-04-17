using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06._02
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void линейныйАлгоритмToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Line line = new Line();
            line.MdiParent = this;
            line.Show();
        }

        private void разветвляющийсяАлгоритмToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Branches branches = new Branches();
            branches.MdiParent = this;
            branches.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Line line = new Line();
            line.MdiParent = this;
            line.Show();
        }
    }
}
