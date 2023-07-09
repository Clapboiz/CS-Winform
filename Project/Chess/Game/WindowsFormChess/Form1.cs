using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sakk_Alkalmazás_2._0
{
    public partial class Form1 : Form
    {
        private TcpClient clientSocket;
        private NetworkStream stream;
        private bool clientRunning;
        private bool isConnected;
        private bool inroom = false;
        public Form1()
        {
            InitializeComponent();
            clientRunning = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!clientRunning)
            {
                clientSocket = new TcpClient();
                clientSocket.Connect("127.0.0.1", 9999);
                stream = clientSocket.GetStream();

                Thread receiveThread = new Thread(ReceiveMessages);
                receiveThread.Start();

                clientRunning = true;
                textBox1.Text += "Client connected to server.\r\n";
            }
        }
        private void ReceiveMessages()
        {
            while (clientRunning & !inroom)
            {
                byte[] buffer = new byte[1024];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
               
                string data = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                if (data.Trim().ToLower() == "clear")
                {
                    continue; // Skip processing the "clear" message
                }
                data = data.Substring(4);
                    // Process the received message
                    // For example, update the UI with the received data
                    textBox1.Invoke(new Action(() =>
                    {
                        textBox1.Clear();
                        string[] roomMessages = data.Split(',');
                        for (int i = 0; i < roomMessages.Length; i += 2)
                        {
                            if (i + 1 < roomMessages.Length)
                            {
                                string roomId = roomMessages[i];
                                string status = roomMessages[i + 1] == "0" ? "full" : "not full";
                                textBox1.Text += $"Room ID: {roomId} - Status: {status}\r\n";
                            }
                        }
                    }));
                

            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (clientRunning)
            {
                clientRunning = false;
                stream.Close();
                clientSocket.Close();
                textBox1.Text += "Client disconnected from server.\r\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inroom = true;
            send_message("create");
            InGameForm newGame = new InGameForm(false, true, stream);
            Visible = false;
            if (!newGame.IsDisposed)
                newGame.ShowDialog();
            Visible = true;
        }
        private void send_message(string data)
        {
            if (clientRunning)
            {
                string message = data;
                byte[] sendData = Encoding.UTF8.GetBytes(message);
                stream.Write(sendData, 0, sendData.Length);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inroom = true;
            send_message("join:" + textBox2.Text);
            InGameForm newGame = new InGameForm(false, false, stream);
            Visible = false;
            if (!newGame.IsDisposed)
                newGame.ShowDialog();
            Visible = true;
        }
    }
}
