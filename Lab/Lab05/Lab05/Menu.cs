using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_Bai01_Click(object sender, EventArgs e)
        {
            new Bai01().Show();
        }

        private void btn_Bai02_Click(object sender, EventArgs e)
        {
            new Bai02().Show();
        }

        private void btn_Bai03_Click(object sender, EventArgs e)
        {
            new Bai03().Show();
        }

        private void btn_Bai04_Click(object sender, EventArgs e)
        {
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_Bai03_Compose_Click(object sender, EventArgs e)
        {
        }
    }
}
