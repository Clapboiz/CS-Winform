using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Lab03
{
    public partial class Bai03_Server : Form
    {
        public Bai03_Server()
        {
            InitializeComponent();
        }

        private void btn_listen_click(object sender, EventArgs e)
        {
            //Xử lý lỗi invalidoperationexception
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            //IsBackground của luồng mới là true, để đảm bảo rằng luồng sẽ tự động kết thúc khi chương trình chính kết thúc.
            serverThread.IsBackground = true;
            serverThread.Start();
            btn_listen.Enabled = false;
        }

        private void StartUnsafeThread()
        {
            int bytesReceived = 0;
            //Khời tạo mảng byte nhận dữ liệu
            byte[] recv = new byte[1];

            //Tạo socket bên gửi
            Socket clientSocket;

            //tạo socket bên nhận, socket này là socket lắng nghe các kết nối đến IP của máy. Đây là 1 TCP/IP socket
            //AddressFamily trả về họ địa chỉ của IP
            //Socket type kiểu kết nối socket, ở đây dùng luồng stream để nhận dữ liệu 
            //ProtocolType sử dụng giao thức kết nối nào, đây dùng TCP
            Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iPEndSever = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listView1.Items.Add(new ListViewItem("Server running on 127.0.0.1:8080 \n"));

            //Gán socket lắng nghe tới địa chỉ IP của máy và port
            listenerSocket.Bind(iPEndSever);
            //Bắt đầu lắng nghe
            listenerSocket.Listen(-1);
            //Đồng ý kết nối
            clientSocket = listenerSocket.Accept();
            //Nhận dữ liệu
            listView1.Items.Add(new ListViewItem("New client connected from " 
                + ((IPEndPoint)clientSocket.RemoteEndPoint).Address.ToString() + ":" 
                + ((IPEndPoint)clientSocket.RemoteEndPoint).Port.ToString()));

            while (clientSocket.Connected)
            {
                //Khởi tạo một chuỗi rỗng để lưu trữ dữ liệu nhận được
                string text = "";
                //Khởi tạo một mảng byte để lưu trữ dữ liệu nhận được
                byte[] buffer = new byte[1024];
                //Tạo biến index để theo dõi số byte nhận được
                int index = 0;

                //Dữ liệu được nhận từ khách hàng thông qua phương thức Receive của socket và được lưu trữ trong biến recv
                //Dữ liệu nhận được được chuyển đổi thành chuỗi và nối vào chuỗi text.
                do
                {
                    bytesReceived = clientSocket.Receive(recv);
                    text += Encoding.UTF8.GetString(recv);

                    //Dữ liệu nhận được được sao chép vào mảng byte buffer.
                    Buffer.BlockCopy(recv, 0, buffer, index, bytesReceived);
                    //Tăng index lên để theo dõi số byte đã nhận được.
                    index++;
                }
                //Kiểm tra xem nếu dữ liệu là "quit\n", tức là khách hàng muốn ngắt kết nối,
                //thì máy chủ sẽ thêm một tin nhắn vào ListView để thông báo rằng khách hàng đã ngắt kết nối và thoát khỏi vòng lặp.
                while (text[text.Length - 1] != '\n');
                if (text == "quit\n")
                {
                    listView1.Items.Add(new ListViewItem("Client disconnected."));
                    break;
                }
                text = Encoding.UTF8.GetString(buffer);
                listView1.Items.Add(new ListViewItem(text));
            }
            clientSocket.Close();
            listenerSocket.Close();
            btn_listen.Enabled = true;
        }
    }
}
