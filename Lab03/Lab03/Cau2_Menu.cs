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
    public partial class Cau2_Menu : Form
    {
        public Cau2_Menu()
        {
            InitializeComponent();
        }

        private void btn_open_click(object sender, EventArgs e)
        {
            new Form().Show();
        }
    }
}
