using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Bai04_Menu : Form
    {
        public Bai04_Menu()
        {
            InitializeComponent();
        }

        private void btn_open(object sender, EventArgs e)
        {
            new Bai04_Server().Show();
        }

        private void btn_chat(object sender, EventArgs e)
        {
            new Bai04_Client().Show();
        }
    }
}
