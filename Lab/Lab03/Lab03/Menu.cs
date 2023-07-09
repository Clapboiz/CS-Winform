using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab3;
using Lab03;

namespace Lab03
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_Bai03(object sender, EventArgs e)
        {
            new Bai03_Menu().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Bai01_Menu().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Bai04_Menu().Show();
        }

        private void btn_Bai02_click(object sender, EventArgs e)
        {
            Bai2 b2 = new Bai2();
            b2.ShowDialog();
        }
    }
}
