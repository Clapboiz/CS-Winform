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

namespace Lab04
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void btn_Get_Click(object sender, EventArgs e)
        {
            try
            {
                //gọi hàm getHTML và truyền vào URL người dùng nhập, Nếu URL hợp lệ,
                //hàm getHTML sẽ trả về nội dung HTML và được hiển thị trên richTextBox
                richTextBox1.Text = getHTML(box_url.Text);
            }
            catch
            {
                //Trường hợp URL không hợp lệ, sẽ bắt được lỗi và hiển thị thông báo lỗi. Sau đó xóa nội dung trong ô URL.
                MessageBox.Show("URL không tồn tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                box_url.Text = "http://";
            }
        }

        private string getHTML(string szURL)
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(szURL);
            // Get the response.
            WebResponse response = request.GetResponse();
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Close the response.
            response.Close();
            return responseFromServer;
        }

    }
}
