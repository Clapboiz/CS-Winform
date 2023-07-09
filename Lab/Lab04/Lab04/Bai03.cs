using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Lab04
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            //Kiểm tra xem người dùng có nhập URL là http:// hoặc rỗng không. Nếu có thì báo lỗi.       
            if (box_url.Text == "http://" || box_url.Text == string.Empty)
            {
                //Hiển thị thông báo lỗi yêu cầu người dùng nhập URL
                MessageBox.Show("Nhập URL!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Kiểm tra xem người dùng có nhập đường dẫn lưu file không. Nếu rỗng thì báo lỗi.
            else if (box_save.Text == string.Empty)
            {
                //Hiển thị thông báo lỗi yêu cầu người dùng nhập đường dẫn lưu file.
                MessageBox.Show("Nhập đường dẫn lưu file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Kiểm tra xem cả URL và đường dẫn đều hợp lệ, khác rỗng và khác http://. Nếu đúng thì tiến hành tải file.
            if (box_save.Text != string.Empty && box_url.Text != "http://" && box_url.Text != string.Empty)
            {
                try
                {
                    //Khởi tạo đối tượng WebClient để tải file.
                    WebClient myClient = new WebClient();
                    //Mở stream đọc file từ URL người dùng nhập.
                    Stream response = myClient.OpenRead(box_url.Text);
                    //Tải file và lưu vào đường dẫn người dùng chỉ định.
                    myClient.DownloadFile(box_url.Text, box_save.Text);

                    //Đọc stream bằng StreamReader
                    StreamReader reader = new StreamReader(response);

                    //Đọc toàn bộ nội dung stream và hiển thị lên richTextBox
                    richTextBox1.Text = reader.ReadToEnd();
                }

                //Xử lý trường hợp có lỗi, hiển thị thông báo lỗi và xóa nội dung trong ô URL.
                catch
                {
                    MessageBox.Show("URL không tồn tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    box_url.Text = "http://";
                }
            }
        }
    }
}
