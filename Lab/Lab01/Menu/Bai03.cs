namespace Bai03
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CD_Click(object sender, EventArgs e)
        {
            string data = comboBox1.SelectedItem.ToString();
            double value1 = double.Parse(TienChuyen.Text);
            double value2;
            if (data == "USD (Đô la Mỹ)")
            {
                value2 = value1 * 22772;
                TienDoi.Text = value2.ToString();
                GiaDoi.Text = "1 USD = 22,772 VNĐ";
            }
            else if (data == "EUR (Euro)")
            {
                value2 = value1 * 28132;
                TienDoi.Text = value2.ToString();
                GiaDoi.Text = "1 EUR = 28,132 VNĐ";
            }
            else if (data == "GBP (Bảng Anh)")
            {
                value2 = value1 * 31538;
                TienDoi.Text = value2.ToString();
                GiaDoi.Text = "1 GBP = 31,538 VNĐ";
            }
            else if (data == "SGD (Đô-la Singapore)")
            {
                value2 = value1 * 17286;
                TienDoi.Text = value2.ToString();
                GiaDoi.Text = "1 SGD = 17,286 VNĐ";
            }
            else if (data == "JPY (Yên Nhật)")
            {
                value2 = value1 * 214;
                TienDoi.Text = value2.ToString();
                GiaDoi.Text = "1 JPY = 214 VNĐ";
            }
        }
    }
}