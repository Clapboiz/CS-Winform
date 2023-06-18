Bai01.Forms.Form1 myForm = new Bai01.Forms.Form1();
myForm.Show();


namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bai01ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bai02ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Bai01_Click(object sender, EventArgs e)
        {
            Bai01 Bai1 = new Bai01();
            Bai1.ShowDialog();
        }

        private void Bai02_Click(object sender, EventArgs e)
        {

        }
    }
}
