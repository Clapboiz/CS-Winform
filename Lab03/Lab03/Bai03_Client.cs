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
    public partial class Bai03_Client : Form
    {
        public Bai03_Client()
        {
            InitializeComponent();
        }

        TcpClient tcpClient;
        IPEndPoint iPEndPoint;
        NetworkStream networkStream;
        Byte[] data;

        private void Bai03_Client_Load(object sender, EventArgs e)
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
                MessageBox.Show("You must turn onlisten server");
                this.Close();
            }
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btn_send(object sender, EventArgs e)
        {
            //Dùng write để gửi dữ liệu đến server
            this.data = Encoding.UTF8.GetBytes("Phạm Công Lập - 21522281 \n" + "Nguyễn Đại Bảo Duy - 21520772 \n");

            networkStream.Write(data, 0, data.Length);
        }

        private void Lab3_Bai3_Cli_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
