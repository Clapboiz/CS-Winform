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
    public partial class Bai03_Menu : Form
    {
        public Bai03_Menu()
        {
            InitializeComponent();
        }

        private void btn_client(object sender, EventArgs e)
        {
            new Bai03_Client().Show();
        }

        private void btn_server(object sender, EventArgs e)
        {
            new Bai03_Server().Show();
        }

        private void Bai03_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
