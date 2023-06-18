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
    public partial class Bai04_Server : Form
    {
        private static List<Socket> clientSockets = new List<Socket>();

        public Bai04_Server()
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
            //Khai báo một biến clientSocket với kiểu dữ liệu Socket để đại diện cho kết nối đến máy chủ.
            Socket clientSocket;
            //Khai báo một biến listenerSocket với kiểu dữ liệu Socket để đại diện cho máy chủ và khởi tạo nó bằng cách sử dụng constructor của lớp Socket
            Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //Khai báo một biến iPEndSever với kiểu dữ liệu IPEndPoint để lưu trữ địa chỉ IP và cổng của máy chủ mà chúng ta muốn kết nối đến. 
            IPEndPoint iPEndSever = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listView1.Items.Add(new ListViewItem("Server running on 127.0.0.1:8080"));

            //Gán socket lắng nghe tới địa chỉ IP của máy và port
            listenerSocket.Bind(iPEndSever);
            //Bắt đầu lắng nghe
            listenerSocket.Listen(-1);

            //sau đó tạo luồng cho việc lắng nghe từ nhiều client tới
            clientSocket = default(Socket);
            while (true)
            {
                clientSocket = listenerSocket.Accept();
                clientSockets.Add(clientSocket);
                CheckForIllegalCrossThreadCalls = false;
                Thread clientThrd = new Thread(new ThreadStart(() => this.clientProcess(clientSocket)));
                clientThrd.IsBackground = true;
                clientThrd.Start();
            }

        }
        //xử lý các gói tin tới thành string và gửi lại các tin nhắn cho tất cả các client
        public void clientProcess(Socket clientSocket)
        {
            int bytesReceived = 0;
            //Khời tạo mảng byte nhận dữ liệu
            byte[] recv = new byte[1];
            //sử dụng để thêm một ListViewItem mới vào danh sách listView1 để thông báo rằng một máy khách mới đã kết nối đến máy chủ.
            listView1.Items.Add(new ListViewItem("New client connected from "
                + ((IPEndPoint)clientSocket.RemoteEndPoint).Address.ToString() + ":"
                + ((IPEndPoint)clientSocket.RemoteEndPoint).Port.ToString()));

            while (clientSocket.Connected)
            {
                byte[] buffer = new byte[1024];
                string text = "";

                do
                {
                    //sử dụng phương thức Receive() của đối tượng clientSocket để nhận dữ liệu từ máy khách và đưa nó vào mảng byte buffer.
                    //Phương thức Receive() sẽ trả về số lượng byte thực sự đã nhận được và lưu trữ trong biến bytesReceived.
                    bytesReceived = clientSocket.Receive(buffer);
                    if (bytesReceived > 0)
                    {
                        //Sau khi dữ liệuđã được chuyển đổi thành chuỗi text, nó được thêm vào biến text bằng toán tử chuỗi +=.
                        text += Encoding.UTF8.GetString(buffer, 0, bytesReceived);
                    }
                } while (bytesReceived == buffer.Length && !text.EndsWith("\n"));

                //sử dụng để kiểm tra xem chuỗi text nhận được từ máy khách có phải là chuỗi "quit" hay không.
                //Nếu đúng, thì chương trình sẽ ngắt kết nối với máy khách và xóa đối tượng clientSocket khỏi danh sách clientSockets.

                if (text.Trim().ToLower() == "quit")
                {
                    string disconnectMess = "Client from " + ((IPEndPoint)clientSocket.RemoteEndPoint).Address.ToString()
                        + ":" + ((IPEndPoint)clientSocket.RemoteEndPoint).Port.ToString() + " disconnected";
                    listView1.Items.Add(new ListViewItem(disconnectMess));
                    sendAllClients(disconnectMess);
                    clientSockets.Remove(clientSocket);
                    return;
                }

                //sử dụng để gửi thông điệp từ máy khách cho tất cả các máy khách khác đang kết nối đến máy chủ.
                listView1.Items.Add(new ListViewItem(((IPEndPoint)clientSocket.RemoteEndPoint).Address.ToString() + ":"
                    + ((IPEndPoint)clientSocket.RemoteEndPoint).Port.ToString() + ": " + text.TrimEnd()));
                sendAllClients(text);

            }
            clientSocket.Close();
        }
            //gửi tin nhắn lại cho tát cả các client
            public void sendAllClients(string text)
        {
            byte[] data = Encoding.UTF8.GetBytes(text);
            //Vòng lặp foreach được sử dụng để duyệt qua danh sách clientSockets và gửi dữ liệu đến từng đối tượng clientSocket bằng phương thức Send() của đối tượng Socket.
            foreach (Socket subclient in clientSockets)
            {
                if (subclient != null)
                {
                    subclient.Send(data);
                }

            }
        }
    }
}
