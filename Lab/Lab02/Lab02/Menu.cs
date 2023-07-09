using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bai03;
using Bai04;
using Bai05;
using Lab02;
using LAB2;

namespace Lab02
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Bai1_Click(object sender, EventArgs e)
        {
            new Bai01().Show();
        }

        private void Bai2_Click(object sender, EventArgs e)
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
