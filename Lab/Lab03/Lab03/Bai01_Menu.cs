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
    public partial class Bai01_Menu : Form
    {
        public Bai01_Menu()
        {
            InitializeComponent();
        }

        private void btn_server_Click(object sender, EventArgs e)
        {
            new Bai01_Server().Show();
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            new Bai01_Client().Show();

        }
    }
}
