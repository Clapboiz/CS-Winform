using System;

namespace Bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string process = "";
        float num1, num2;
        private void button16_Click(object sender, EventArgs e)
        {
            Hienthi1.Text = Hienthi1.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Hienthi1.Text = Hienthi1.Text + "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Hienthi1.Text = Hienthi1.Text + "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Hienthi1.Text = Hienthi1.Text + "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hienthi1.Text = Hienthi1.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hienthi1.Text = Hienthi1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hienthi1.Text = Hienthi1.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hienthi1.Text = Hienthi1.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hienthi1.Text = Hienthi1.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hienthi1.Text = Hienthi1.Text + "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Hienthi1.Text = Hienthi1.Text + ".";
        }

        private void Hienthi1_TextChanged(object sender, EventArgs e)
        {
            if (Hienthi1.Text.StartsWith("0") && Hienthi1.Text.Length > 1)
            {
                Hienthi1.Text = Hienthi1.Text.TrimStart('0');
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Hienthi1.Text = "0";
            Hienthi2.Text = "0";
            num2 = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Hienthi1.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (num2 == 0)
                num2 = float.Parse(Hienthi1.Text);
            else
                switch (process)
                {
                    case "+":
                        num2 = num1 + float.Parse(Hienthi1.Text);
                        Hienthi2.Text = num1.ToString() + " + " + float.Parse(Hienthi1.Text) + " = ";
                        Hienthi1.Text = num2.ToString();
                        break;
                    case "-":
                        num2 = num1 - float.Parse(Hienthi1.Text);
                        Hienthi2.Text = num1.ToString() + " - " + float.Parse(Hienthi1.Text) + " = ";
                        Hienthi1.Text = num2.ToString();
                        break;
                    case "/":
                        if (float.Parse(Hienthi1.Text) == 0)
                        {
                            Hienthi2.Text = num1.ToString() + " / ";

                            Hienthi1.Text = "Cannot divide by zero";
                        }
                        else
                        {
                            num2 = num1 / float.Parse(Hienthi1.Text);
                            Hienthi2.Text = num1.ToString() + " / " + float.Parse(Hienthi1.Text) + " = ";
                            Hienthi1.Text = num2.ToString();
                        }

                        break;
                    case "*":
                        num2 = num1 * float.Parse(Hienthi1.Text);
                        Hienthi2.Text = num1.ToString() + " * " + float.Parse(Hienthi1.Text) + " = ";
                        Hienthi1.Text = num2.ToString();
                        break;

                    case "2":
                        num2 = (float)Math.Pow(num1, 2);
                        Hienthi2.Text = num1.ToString() + "^2" + " = ";
                        Hienthi1.Text = num2.ToString();
                        break;

                    case "^":
                        num2 = (float)Math.Pow(num1, float.Parse(Hienthi1.Text));
                        Hienthi2.Text = num1.ToString() + " ^ " + float.Parse(Hienthi1.Text) + " = ";
                        Hienthi1.Text = num2.ToString();
                        break;

                    case "s":
                        num2 = (float)Math.Sin(num1 * Math.PI / 180);
                        Hienthi2.Text = "sin(" + num1.ToString() + ") = ";
                        Hienthi1.Text = num2.ToString();
                        break;

                    case "c":
                        num2 = (float)Math.Cos(num1 * Math.PI / 180);
                        Hienthi2.Text = "cos(" + num1.ToString() + ") = ";
                        Hienthi1.Text = num2.ToString();
                        break;

                    case "t":
                        num2 = (float)Math.Tan(num1 * Math.PI / 180);
                        Hienthi2.Text = "tan(" + num1.ToString() + ") = ";
                        Hienthi1.Text = num2.ToString();
                        break;

                    case "10^x":
                        num2 = (float)Math.Pow(10, num1);
                        Hienthi2.Text = "10^(" + num1.ToString() + ") = ";
                        Hienthi1.Text = num2.ToString();
                        break;


                    case "√":
                        num2 = (float)Math.Sqrt(num1);
                        Hienthi2.Text = "sqrt(" + num1.ToString() + ") = ";
                        Hienthi1.Text = num2.ToString();
                        break;

                    case "log":
                        num2 = (float)Math.Log10(num1);
                        Hienthi2.Text = "log(" + num1.ToString() + ") = ";
                        Hienthi1.Text = num2.ToString();
                        break;

                    case "!":
                        int n = (int)num1;
                        num2 = 1;
                        for (int i = 1; i <= n; i++)
                        {
                            num2 *= i;
                        }
                        Hienthi2.Text = n.ToString() + "! = ";
                        Hienthi1.Text = num2.ToString();
                        break;

                    case "%":
                        num2 = num1 % float.Parse(Hienthi1.Text);
                        Hienthi2.Text = num1.ToString() + " % " + float.Parse(Hienthi1.Text) + " = ";
                        Hienthi1.Text = num2.ToString();
                        break;

                    case "exp":
                        num2 = (float)Math.Exp(num1);
                        Hienthi2.Text = "exp(" + num1.ToString() + ") = ";
                        Hienthi1.Text = num2.ToString();
                        break;

                    case "M+":
                        num2 += float.Parse(Hienthi1.Text);
                        Hienthi1.Text = num2.ToString();
                        break;

                    case "M-":
                        num2 -= float.Parse(Hienthi1.Text);
                        Hienthi1.Text = num2.ToString();
                        break;

                    case "MS":
                        num1 = float.Parse(Hienthi1.Text);
                        num2 = num1;
                        break;

                    case "+/-":
                        num2 = -1 * num1;
                        Hienthi2.Text = num1.ToString();
                        Hienthi1.Text = num2.ToString();
                        break;


                    default:
                        break;
                }

            num1 = float.Parse(Hienthi1.Text);
            process = " ";
        }


        private void button4_Click(object sender, EventArgs e)
        {
            button14_Click(sender, e);
            process = "+";
            num1 = float.Parse(Hienthi1.Text);
            Hienthi2.Text = num1.ToString() + " + ";
            Hienthi1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button14_Click(sender, e);
            process = "-";
            num1 = float.Parse(Hienthi1.Text);
            Hienthi2.Text = num1.ToString() + " - ";
            Hienthi1.Clear();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            button14_Click(sender, e);
            process = "*";
            num1 = float.Parse(Hienthi1.Text);
            Hienthi2.Text = num1.ToString() + " * ";
            Hienthi1.Clear();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            button14_Click(sender, e);
            process = "/";
            num1 = float.Parse(Hienthi1.Text);
            Hienthi2.Text = num1.ToString() + " / ";
            Hienthi1.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            button14_Click(sender, e);
            process = "2";
            num1 = float.Parse(Hienthi1.Text);
            Hienthi2.Text = num1.ToString() + " ^ ";
            Hienthi1.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button14_Click(sender, e);
            process = "^";
            num1 = float.Parse(Hienthi1.Text);
            Hienthi2.Text = num1.ToString() + " ^ ";
            Hienthi1.Clear();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button14_Click(sender, e);
            process = "s";
            num1 = float.Parse(Hienthi1.Text);
            Hienthi2.Text = num1.ToString() + " sin ";
            Hienthi1.Clear();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button14_Click(sender, e);
            process = "c";
            num1 = float.Parse(Hienthi1.Text);
            Hienthi2.Text = num1.ToString() + " cos ";
            Hienthi1.Clear();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button14_Click(sender, e);
            process = "t";
            num1 = float.Parse(Hienthi1.Text);
            Hienthi2.Text = num1.ToString() + " tan ";
            Hienthi1.Clear();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button14_Click(sender, e);
            process = "√";
            num1 = float.Parse(Hienthi1.Text);
            Hienthi2.Text = num1.ToString() + " √ ";
            Hienthi1.Clear();
        }

        //10^x
        private void button25_Click(object sender, EventArgs e)
        {
            button14_Click(sender, e);
            process = "10^x";
            num1 = float.Parse(Hienthi1.Text);
            Hienthi2.Text = num1.ToString() + " ^ ";
            Hienthi1.Clear();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button14_Click(sender, e);
            process = "log";
            num1 = float.Parse(Hienthi1.Text);
            Hienthi2.Text = num1.ToString() + " log ";
            Hienthi1.Clear();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button14_Click(sender, e);
            process = "exp";
            num1 = float.Parse(Hienthi1.Text);
            Hienthi2.Text = num1.ToString() + " exp ";
            Hienthi1.Clear();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button14_Click(sender, e);
            process = "%";
            num1 = float.Parse(Hienthi1.Text);
            Hienthi2.Text = num1.ToString() + " mod ";
            Hienthi1.Clear();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button14_Click(sender, e);
            process = "!";
            num1 = float.Parse(Hienthi1.Text);
            Hienthi2.Text = num1.ToString() + " n! ";
            Hienthi1.Clear();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Hienthi1.Text = Hienthi1.Text + ")";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Hienthi1.Text = Hienthi1.Text + "(";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            double pi = Math.PI;
            Hienthi1.Text = pi.ToString();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            button14_Click(sender, e);
            process = "M+";
            num1 = float.Parse(Hienthi1.Text);
            Hienthi2.Text = num1.ToString() + " M+ ";
            Hienthi1.Clear();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            button14_Click(sender, e);
            process = "M-";
            num1 = float.Parse(Hienthi1.Text);
            Hienthi2.Text = num1.ToString() + " M- ";
            Hienthi1.Clear();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            button14_Click(sender, e);
            process = "MS";
            num1 = float.Parse(Hienthi1.Text);
            Hienthi2.Text = num1.ToString() + " MS ";
            Hienthi1.Clear();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            button14_Click(sender, e);
            process = "+/-";
            num1 = float.Parse(Hienthi1.Text);
            Hienthi2.Text = num1.ToString() + " +/- ";
            Hienthi1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}