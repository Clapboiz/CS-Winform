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
using System.Net.WebSockets;



namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // StartUnsafeThread() is responsible for setting up a server socket, accepting client connections, and receiving data from the connected clients.
        // The StartUnsafeThread() method creates a socket named listenerSocket using the TCP protocol. It binds the socket to a specific IP address and port.
        void StartUnsafeThread()
        {
            int byteReceived = 0;
            
            byte[] recv = new byte[1];

            Socket clientSocket;

            // The listenerSocket is put into listening mode using the Listen() method.
            Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("192.168.56.1"), 8080);

            listenerSocket.Bind(ipepServer);

            listenerSocket.Listen(-1);

            // When a client connects to the server, the Accept() method is called, which blocks until a client connection is established. Once a connection is accepted, a new socket named clientSocket is created to handle communication with the connected clien

            clientSocket = listenerSocket.Accept();

            _text.Items.Add(new ListViewItem("New client connnected"));
            while (clientSocket.Connected)
            {
                string text = "";
                do
                {
                    // Reads the received bytes and converts them to a UTF-8 encoded string
                    byteReceived = clientSocket.Receive(recv);

                    // The received text is appended to a string variable named text. The loop continues receiving data until a newline character is encountered.
                    text += Encoding.UTF8.GetString(recv);

                } while (text[text.Length - 1 ] != '\n');



                _text.Items.Add(new ListViewItem(text));
            }
            listenerSocket.Close();

        }

        private void _listen_Click(object sender, EventArgs e)
        {
            //To handle invalid operation exception 
            CheckForIllegalCrossThreadCalls = false;
            Thread severThread = new Thread(new ThreadStart(StartUnsafeThread));
            severThread.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void _text_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
