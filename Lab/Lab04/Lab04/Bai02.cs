using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04;

public partial class Bai02 : Form
{
    public Bai02()
    {
        InitializeComponent();
    }
    private void _post_Click(object sender, EventArgs e)
    {
            string url = _url.Text;
            //string url = "http://www.contoso.com/PostAccepter.aspx";
            
            string data = _content.Text;
            

            // Tạo dữ liệu POST theo định dạng key=value&key=value
            //string postData = $"data={data}";

            // Convert dữ liệu POST sang mảng byte
            byte[] byteArray = Encoding.UTF8.GetBytes(data);

            try
            {
                // Khởi tạo yêu cầu với địa chỉ URL
                WebRequest request = WebRequest.Create(url);
                request.Method = "POST";

                // Thiết lập độ dài nội dung trả về
                request.ContentLength = byteArray.Length;

                // Thiết lập thuộc tính Content Type
                request.ContentType = "application/x-www-form-urlencoded";  //giải thích thêm tái sao lại xài


            /*Thuộc tính Content-Type trong yêu cầu HTTP xác định kiểu dữ liệu đang được gửi trong nội dung yêu cầu. Trong trường hợp "application/x-www-form-urlencoded",
            nó cho biết rằng dữ liệu đang được gửi theo chuẩn x-www-form-urlencoded.
            Chuẩn mã hóa x-www-form-urlencoded được sử dụng khi gửi dữ liệu từ một form HTML. 
            Khi gửi yêu cầu HTTP, các giá trị từ các trường form sẽ được mã hóa và gửi theo định dạng key=value&key=value.
            */

            /*
            Dữ liệu trong biến data sẽ được mã hóa theo chuẩn x-www-form-urlencoded. Sử dụng như vậy để báo cho máy chủ rằng dữ liệu được gửi theo chuẩn này để nó hiểu và xử lý
            */
            // Tạo request stream bằng cách get request stream từ WebRequest
            using (Stream dataStream = request.GetRequestStream())
                {
                    // Ghi dữ liệu vào request stream
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }

                // Lấy phản hồi từ WebRequest
                using (WebResponse response = request.GetResponse())
                using (Stream dataStream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(dataStream))
                {
                    // Đọc dữ liệu từ response stream
                    string responseFromServer = reader.ReadToEnd();

                    // Xử lý nội dung phản hồi theo yêu cầu của bạn
                    _response.Text=responseFromServer;
                }
            
            

        }
        catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    private void Bai02_Load(object sender, EventArgs e)
    {

    }
}
