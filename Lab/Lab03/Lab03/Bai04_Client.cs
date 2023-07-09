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
    public partial class Bai04_Client : Form
    {
        public Bai04_Client()
        {
            InitializeComponent();
        }

        TcpClient tcpClient;
        IPEndPoint iPEndPoint;
        NetworkStream networkStream;
        Byte[] data;

        private void Bai04_Client_Load(object sender, EventArgs e)
        {
            try
            {
                //Tạo đối tượng TCP client
                this.tcpClient = new TcpClient();
                //Kết nối tới server với IP và port
                this.iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
                this.tcpClient.Connect(iPEndPoint);
                //Tạo luồng đọc và ghi dữ liệu dựa trên Networkstream
                this.networkStream = tcpClient.GetStream();
            }
            catch
            {
                MessageBox.Show("You must turn on listen server");
                this.Close();
            }
            CheckForIllegalCrossThreadCalls = false;

            //tạo luồng lắng nghe server khi vừa kết nối tới
            Thread listen = new Thread(receive);
            listen.IsBackground = true;
            listen.Start();
        }

        private void btn_send_click(object sender, EventArgs e)
        {
            //Kiểm tra xem cả hai đối tượng TextBox chứa địa chỉ IP và nội dung tin nhắn có được nhập vào hay không.
            //Nếu một trong hai đối tượng TextBox rỗng, phương thức sẽ không thực hiện thêm bất kỳ hành động nào.
            if (textBox1.Text.Trim() != string.Empty && textBox2.Text.Trim() != string.Empty)
            {
                try
                {
                    //Tạo chuỗi tin nhắn mới bằng cách kết hợp địa chỉ IP và nội dung tin nhắn được nhập từ hai đối tượng TextBox
                    //Chuỗi tin nhắn được định dạng để có thể hiển thị địa chỉ IP và nội dung tin nhắn trên các dòng khác nhau
                    string strSend = textBox1.Text.Trim() + ": " + textBox2.Text.Trim() + "\n";
                    //Chuyển đổi chuỗi tin nhắn thành một mảng byte bằng phương thức GetBytes() của lớp Encoding
                    byte[] sendBytes = Encoding.UTF8.GetBytes(strSend);

                    //Gửi mảng byte chứa nội dung tin nhắn đi qua giao thức TCP bằng phương thức Write() của đối tượng NetworkStream
                    networkStream.Write(sendBytes, 0, sendBytes.Length);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error sending message: " + ex.Message);
                }
            }
        }

        //hàm xử lý nhận tin gửi tới
        public void receive()
        {
            try
            {
                //Lặp vô hạn với câu lệnh while (true).Điều này cho phép tiếp tục lắng nghe và hiển thị tin nhắn đến từ máy chủ một cách liên tục.
                while (true)
                {
                    byte[] data = new byte[1024];
                    //Sử dụng phương thức Read() của đối tượng NetworkStream để đọc tin nhắn đến từ máy chủ
                    networkStream.Read(data, 0, data.Length);
                    //Chuyển đổi mảng byte chứa nội dung tin nhắn thành chuỗi sử dụng phương thức GetString() của lớp Encoding
                    string message = Encoding.UTF8.GetString(data);

                    // Lấy tên user của người gửi tin nhắn
                    string senderName = message.Split(':')[0].Trim();

                    // Tạo một đối tượng ListViewItem mới
                    var item = new ListViewItem(message);

                    // Kiểm tra xem người gửi tin nhắn có phải là user của bạn hay không
                    if (senderName == "Tên user của bạn")
                    {
                        // Nếu tin nhắn đến từ user của bạn, đặt màu nền của ListViewItem thành màu xám
                        item.BackColor = Color.LightGray;
                    }
                    else
                    {
                        // Nếu tin nhắn đến từ các user khác, đặt màu nền của ListViewItem thành màu trắng
                        item.BackColor = Color.White;
                    }

                    // Thêm đối tượng ListViewItem mới vào ListView để hiển thị tin nhắn
                    listView1.Items.Add(item);
                }
            }
            catch
            {
                MessageBox.Show("Cannot connect to server. Disconnected or lost connection");
                Close();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
