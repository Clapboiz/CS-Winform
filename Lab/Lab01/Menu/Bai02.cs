namespace Bai02
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            Txt1.Text = "";
            Txt2.Text = "";
        }

        private void Doc_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (int.TryParse(Txt1.Text, out num) && num.ToString().Contains(""))
            {
                // Nếu giá trị của Txt1.Text chứa số 23 thì thực hiện hành động này
            }
            switch (num)
            {
                case 0:
                    Txt2.Text = ("Không");
                    break;
                case 1:
                    Txt2.Text = ("Một");
                    break;
                case 2:
                    Txt2.Text = ("Hai");
                    break;
                case 3:
                    Txt2.Text = ("Ba");
                    break;
                case 4:
                    Txt2.Text = ("Bốn");
                    break;
                case 5:
                    Txt2.Text = ("Năm");
                    break;
                case 6:
                    Txt2.Text = ("Sáu");
                    break;
                case 7:
                    Txt2.Text = ("Bảy");
                    break;
                case 8:
                    Txt2.Text = ("Tám");
                    break;
                case 9:
                    Txt2.Text = ("Chín");
                    break;
            }
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}