using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using System.Diagnostics;

namespace Lab04
{
    public partial class Bai04 : Form
    {
        public Bai04()
        {
            InitializeComponent();
            InitializeComponent1();
            //gắn phương thức xử lý sự kiện btn_home_Click với sự kiện click của button
            btn_home.Click += new EventHandler(btn_home_Click);
        }

        private void Bai04_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com"); //trình duyệt web (webBrowser1) được điều hướng đến trang web Google
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
                webBrowser1.GoBack();
        }

        private void _go_Click(object sender, EventArgs e) //Điều hướng đến một URL cụ thể khi nút "_go" được nhấp
        {
            string url = _url.Text;
            webBrowser1.Navigate(url);
        }

        //sử dụng để chuyển đến trang web tiếp theo trên webBrowser1 nếu có thể.
        private void forward_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
                webBrowser1.GoForward();
        }

        // được sử dụng để tải lại trang web hiện tại trên webBrowser1 của ứng dụng Windows Forms.
        private void refresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void dow_Click(object sender, EventArgs e)
        {
            //nội dung HTML của trang web hiện tại được lưu trong biến html. Một SaveFileDialog được tạo để cho phép người dùng chọn vị trí và tên tệp để lưu nội dung HTML. Sau đó lưu về máy
            
            string html = webBrowser1.DocumentText;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "HTML File (*.html)|*.html";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //được sử dụng để lưu nội dung của trang web hiện tại trên webBrowser1 vào một tệp tin văn bản được chọn bởi người dùng.
                string filePath = saveFileDialog.FileName;
                File.WriteAllText(filePath, html);
                MessageBox.Show("File HTML đã được tải về thành công!");
            }
        }

        private void viewsource_Click(object sender, EventArgs e)
        {
            //nội dung HTML của trang web hiện tại được lấy và hiển thị trong một hộp thoại tin nhắn.
            string html = webBrowser1.DocumentText;
            MessageBox.Show(html, "Mã nguồn HTML");

            
        }

        //được sử dụng để mở trang chủ của Google trên trình duyệt mặc định của hệ thống bằng cách sử dụng Command Prompt
        private void btn_home_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/c start https://www.google.com",
                CreateNoWindow = true
            });
        }
    }
}

