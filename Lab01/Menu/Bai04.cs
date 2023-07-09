using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABB4
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1text = textBox1.Text;
            string s2text = textBox2.Text;
            string s3text = textBox3.Text;
            string s4text = textBox4.Text;
            string s5text = textBox5.Text;
            string s6text = textBox6.Text;
            string s7text = textBox7.Text;

            double s1 = double.Parse(s1text);
            double s2 = double.Parse(s2text);
            double rs1 = 1, rs2 = 1, sum1 = 0, sum2 = 0, sum3 = 0;

            for (int i = 1; i <= s1; i++)
            {
                rs1 *= i;
            }
            for (int i = 1; i <= s2; i++)
            {
                rs2 *= i;
            }
            for (int i = 1; i <= s1; i++)
            {
                sum1 += i;
            }
            for (int i = 1; i <= s2; i++)
            {
                sum2 += i;
            }
            for (int i = 1; i <= s2; i++)
            {
                sum3 += Math.Pow(s1, i);
            }


            textBox3.Text = rs1.ToString();
            textBox4.Text = rs2.ToString();
            textBox5.Text = sum1.ToString();
            textBox6.Text = sum2.ToString();
            textBox7.Text = sum3.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
            textBox6.Text = String.Empty;
            textBox7.Text = String.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
