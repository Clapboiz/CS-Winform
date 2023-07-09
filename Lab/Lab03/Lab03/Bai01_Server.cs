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
using System.Threading;

namespace Lab03
{
    public partial class Bai01_Server : Form
    {
        public Bai01_Server()
        {
            InitializeComponent();
        }

        //Nhận vào một chuỗi và chuyển đổi nó thành một số nguyên
        private int ConvertStringToInt(string str)
        {
            return Convert.ToInt32(str);
        }

        delegate void ShowMessageCallBack(RichTextBox box, string message);

        private void ShowMessage(RichTextBox box, string message)
        {
            if (box.InvokeRequired)
            {
                //ShowMessage() kiểm tra xem liệu phương thức được gọi từ một luồng khác hay không bằng cách 
                //sử dụng thuộc tính InvokeRequired của đối tượng RichTextBox.Nếu phương thức được gọi từ một luồng khác, 
                //phương thức này tạo một đối tượng delegate và sử dụng phương thức 
                //Invoke() để gọi lại phương thức ShowMessage() trong luồng chuẩn bị sẵn của đối tượng RichTextBox.
                ShowMessageCallBack d = new ShowMessageCallBack(ShowMessage);
                this.Invoke(d, new object[] { box, message });
            }

            else
            {
                //kiểm tra xem tin nhắn có hợp lệ hay không trước khi thêm nó vào đối tượng RichTextBox.
                if (message.Length > 0)
                    box.Text += message + "\n";

                else
                    box.Text += "Invalid message!" + "\n";
            }
        }

        private string GetMessage(UdpClient udpClient, IPEndPoint ipEndPoint)
        {
            //Nhận tin nhắn từ client
            Byte[] receiveBytes = udpClient.Receive(ref ipEndPoint);

            string data = Encoding.UTF8.GetString(receiveBytes);
            string message = ipEndPoint.Address.ToString() + ": "
                + ipEndPoint.Port.ToString() + ": " + data.ToString();

            return message;
        }
        //Khởi tạo UDP server, đợi và nhận UDP message từ client, sau đó hiển thị lên giao diện
        private void ServerThread()
        {
            int port = ConvertStringToInt(textBox1.Text);
            UdpClient udpClient = new UdpClient(port);

            while (true)
            {
                IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Any, 0);

                string message = GetMessage(udpClient, ipEndPoint);
                ShowMessage(richTextBox1, message);
            }
        }


        private void Listen_Click(object sender, EventArgs e)
        {
            //khởi tạo một luồng mới để chạy phương thức ServerThread().
            Thread t = new Thread(new ThreadStart(ServerThread));
            t.Start();
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
