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
using System.Net.Sockets;

namespace Lab03
{
    public partial class Bai01_Client : Form
    {
        public Bai01_Client()
        {
            InitializeComponent();
        }

        private int ConvertStringToInt(string str)
        {
            // Convert string sang int32
            return Convert.ToInt32(str);
        }

        private IPEndPoint GetIPEnd(string ipBox, string portText)
        {
            //Nhận IP endpoint
            IPAddress ipAddress = IPAddress.Parse(ipBox);
            int port = ConvertStringToInt(portText);

            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, port);
            return ipEndPoint;
        }

        private void Send_Click(object sender, EventArgs e)
        {
            //sử dụng lớp UdpClient để tạo một đối tượng UdpClient mới.
            //Đối tượng này được sử dụng để gửi một mảng byte chứa nội dung của tin nhắn đến địa chỉ IP và cổng được chỉ định.
            UdpClient udpClient = new UdpClient();

            //sử dụng phương thức GetIPEnd() để lấy địa chỉ IP và cổng từ các đối tượng TextBox.
            IPEndPoint ipEndPoint = GetIPEnd(textBox1.Text, textBox3.Text);

            //Dùng lớp encoding để chuyển nội dung thành mảng byte, textbox chứa nội dung tin nhắn
            Byte[] sendBytes = Encoding.UTF8.GetBytes(textBox2.Text);

            //phương thức Send() của đối tượng UdpClient được sử dụng để gửi tin nhắn đến địa chỉ IP và cổng được chỉ định.
            int sent = udpClient.Send(sendBytes, sendBytes.Length, ipEndPoint);

            //phương thức Send() trả về số byte đã được gửi đi. Số byte này được lưu trữ trong biến sent. Nếu số byte này bằng với số byte trong mảng byte gốc,
            //nghĩa là tất cả các byte đã được gửi đi thành công, phương thức in ra thông báo "Message sent!" và đặt nội dung của đối tượng TextBox chứa tin nhắn
            //thành chuỗi rỗng để chuẩn bị cho tin nhắn tiếp theo. Nếu không, phương thức in ra thông báo "Only [sent] bytes sent." để cho biết chỉ có một phần của tin nhắn được gửi đi.
            if (sent == sendBytes.Length)
            {
                Console.WriteLine("Message sent!");
                textBox2.Text = "";
            }
            else
            {
                Console.WriteLine("Only " + sent + " bytes sent.");
            }
        }

        private void Bai01_Client_Load(object sender, EventArgs e)
        {

        }
    }
}
