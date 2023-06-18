namespace Bai01
{
    public partial class BaiTH1 : Form
    {
        public BaiTH1()
        {
            InitializeComponent();
        }

        private void Tim_Click(object sender, EventArgs e)
        {
            int max = int.Parse(Txt1.Text);
            if (int.Parse(Txt2.Text) > max)
            {
                max = int.Parse(Txt2.Text);
            }
            if (int.Parse(Txt3.Text) > max)
            {
                max = int.Parse(Txt3.Text);
            }

            // Tìm số nhỏ nhất
            int min = int.Parse(Txt1.Text);
            if (int.Parse(Txt2.Text) < min)
            {
                min = int.Parse(Txt2.Text);
            }
            if (int.Parse(Txt3.Text) < min)
            {
                min = int.Parse(Txt3.Text);
            }

            // Hiển thị kết quả
            TxtMax.Text = max.ToString();
            TxtMin.Text = min.ToString();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            Txt1.Text = "";
            Txt2.Text = "";
            Txt3.Text = "";
        }
    }
}