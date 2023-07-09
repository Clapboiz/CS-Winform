using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bai01;
using Bai02;
using Bai03;
using Bai05;
using LABB4;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bai01ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bai02ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Bai01_Click(object sender, EventArgs e)
        {
            new Bai1().Show();
        }

        private void Bai02_Click(object sender, EventArgs e)
        {
            new Bai2().Show();
        }

        private void Bai3_Click(object sender, EventArgs e)
        {
            new Bai3().Show();
        }

        private void Bai4_Click(object sender, EventArgs e)
        {
            new Bai4().Show();

        }

        private void Bai5_Click(object sender, EventArgs e)
        {
            new Bai5().Show();
        }
    }
}
