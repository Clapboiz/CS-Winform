using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_Bai1_Click(object sender, EventArgs e)
        {
            new Bai01().Show();

        }

        private void btn_Bai2_Click(object sender, EventArgs e)
        {
            new Bai02().Show();
        }

        private void btn_Bai3_Click(object sender, EventArgs e)
        {
            new Bai03().Show();
        }

        private void btn_Bai4_Click(object sender, EventArgs e)
        {
            new Bai04().Show();
        }
    }
}
