using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChessAIForms;

namespace Sakk_Alkalmazás_2._0
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            InGameForm inGame = new InGameForm(true, false);
            inGame.ShowDialog();
            this.Close();
        }

        private void Connection_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            //ConnectionForm connectionForm = new ConnectionForm();
            
            //connectionForm.ShowDialog();
            Form1 newform = new Form1();
            newform.ShowDialog();
            this.Close();

        }

        private void AI_Click(object sender, EventArgs e)
        {
            this.Hide();
            AI_Form newform = new AI_Form();
            newform.ShowDialog();
            this.Close();
        }
    }
}
