using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static new_chess_server.Form1;

namespace new_chess_server
{
    public partial class Form1 : Form
    {
        private TcpListener tcpListener = null;
        private List<TcpClient> connectedClients; // Added list of connected clients
        private RoomList serverroomList;
        private System.Windows.Forms.Timer broadcastTimer; // Added timer
        public Form1()
        {
            InitializeComponent();
            serverroomList = new RoomList();

            broadcastTimer = new System.Windows.Forms.Timer();
            broadcastTimer.Interval = 5000; // 5 seconds
            broadcastTimer.Tick += BroadcastTimer_Tick;
        }
        private void BroadcastTimer_Tick(object sender, EventArgs e)
        {
            if (connectedClients != null && connectedClients.Count > 0)
            {
                try
                {
                    // Construct the message
                    StringBuilder messageBuilder = new StringBuilder();
                    foreach (Room room in serverroomList.rooms)
                    {
                        int status = room.Player1 != null && room.Player2 != null ? 0 : 1;
                        messageBuilder.Append($"{room.Id},{status},");
                    }

                    // Remove the trailing ','
                    if (messageBuilder.Length > 0)
                    {
                        messageBuilder.Length -= 1; // Remove the last character: ','
                    }

                    // Iterate through connected clients and send the message
                    foreach (TcpClient clientSocket in connectedClients)
                    {
                            NetworkStream stream = clientSocket.GetStream();
                            try
                            {
                                if (messageBuilder.Length > 0)
                                {
                                    string message = "room" + messageBuilder.ToString();

                                    byte[] sendData = Encoding.UTF8.GetBytes(message);
                                    stream.Write(sendData, 0, sendData.Length);
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("An error occurred while sending the message to a client: " + ex.Message);
                            }
                        
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 9999);
            tcpListener.Start();

            connectedClients = new List<TcpClient>(); // Initialize the list before accepting clients
                                                      // Start accepting client connections in a separate thread
            Thread acceptClientsThread = new Thread(AcceptClients);
            acceptClientsThread.Start();

            textBox1.Text += "Server started.\r\n";
            broadcastTimer.Start();
        }
        private void AcceptClients()
        {
            while (true)
            {
                TcpClient clientSocket = tcpListener.AcceptTcpClient();
                connectedClients.Add(clientSocket); // Add the connected client to the list
                Thread clientThread = new Thread(() => HandleClient(clientSocket));
                clientThread.Start();
            }
        }
        private void HandleClient(TcpClient clientSocket)
        {
            // Get the client's IP address
            string clientIP = ((IPEndPoint)clientSocket.Client.RemoteEndPoint).Address.ToString();

            // Print the client's IP and connection information
            textBox1.Invoke(new Action(() => textBox1.Text += "Client connected: IP = " + clientIP + "\r\n"));

            NetworkStream stream = clientSocket.GetStream();

            byte[] buffer = new byte[1024];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            string data = Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim();

            // Process the client's message
            if (data == "create")
            {
                // Create a new room and add the client as Player1
                Room newRoom = new Room();
                newRoom.initial_status(1);
                newRoom.AddPlayer(clientSocket);
                serverroomList.AddRoom(newRoom);
                newRoom.SetRoomId(serverroomList.GetNextRoomId()); // Set the room ID
            
                // Print the room ID
                textBox1.Invoke(new Action(() => textBox1.Text += clientSocket.ToString()+" created room: ID = " + newRoom.Id + "\r\n"));
                connectedClients.Remove(clientSocket);
            }
            else if (data.StartsWith("join:"))
            {
                // Extract the room ID from the client's message
                string roomIdString = data.Substring(5);
                int roomId;
                if (int.TryParse(roomIdString, out roomId))
                {
                    // Find the requested room by ID
                    Room room = serverroomList.rooms.Find(r => r.Id == roomId);
                    if (room != null && room.Player2 == null)
                    {
                        // Add the client as Player2 to the requested room
                        room.AddPlayer(clientSocket);
                        // Print the room ID
                        textBox1.Invoke(new Action(() => textBox1.Text += "Client "+clientSocket.ToString() +" joined Room: ID = " + room.Id + "\r\n"));
                        connectedClients.Remove(clientSocket);
                        // Start exchanging data between the players
                        Thread exchangeThread = new Thread(room.ExchangeData);
                        exchangeThread.Start();
                    }
                    else
                    {
                        // Room not found or already full
                        textBox1.Invoke(new Action(() => textBox1.Text += "Invalid room ID or room is already full.\r\n"));
                    }
                }
                else
                {
                    // Invalid room ID format
                    textBox1.Invoke(new Action(() => textBox1.Text += "Invalid room ID format.\r\n"));
                }
            }
        }

        public class Room
        {
            public int Id { get; private set; }
            public TcpClient Player1 { get; private set; }
            public TcpClient Player2 { get; private set; }
            public int status { get; private set; }

            private bool exchangeDataOccurred = false;

            public void SetRoomId(int id)
            {
                Id = id;
            }
            public void initial_status(int status)
            {
                this.status = status;
            }

            public void check_room_status()
            {
                if(Player1!=null & Player2 != null)
                {
                    status = 0;
                }
            }
            public void AddPlayer(TcpClient player)
            {
                if (Player1 == null)
                {
                    Player1 = player;
                }
                else if (Player2 == null)
                {
                    Player2 = player;
                }
                else
                {
                    MessageBox.Show("Room is already full");
                }
                check_room_status();
            }

            public void RemovePlayer(TcpClient player)
            {
                if (Player1 == player)
                {
                    Player1 = null;
                }
                else if (Player2 == player)
                {
                    Player2 = null;
                }
            }

            public void ExchangeData()
            {
                if (Player1 != null && Player2 != null)
                {
                    // Exchange data between Player1 and Player2
                    NetworkStream stream1 = Player1.GetStream();
                    NetworkStream stream2 = Player2.GetStream();

                    while (true)
                    {
                        if (!exchangeDataOccurred)
                        {
                            // Send the "clear" message using System
                            byte[] clearData = Encoding.UTF8.GetBytes("clear");
                            stream1.Write(clearData, 0, clearData.Length);
                            stream2.Write(clearData, 0, clearData.Length);
                            exchangeDataOccurred = true;
                        }
                        // Read data from Player1 and send it to Player2
                        if (stream1.DataAvailable)
                        {
                            byte[] buffer = new byte[1024];
                            int bytesRead = stream1.Read(buffer, 0, buffer.Length);
                            if (bytesRead > 0)
                            {
                                stream2.Write(buffer, 0, bytesRead);
                            }
                        }

                        // Read data from Player2 and send it to Player1
                        if (stream2.DataAvailable)
                        {
                            byte[] buffer = new byte[1024];
                            int bytesRead = stream2.Read(buffer, 0, buffer.Length);
                            if (bytesRead > 0)
                            {
                                stream1.Write(buffer, 0, bytesRead);
                            }
                        }
                    }
                }
            }
        }
        public class RoomList
        {
            public List<Room> rooms;
            private Queue<int> availableRoomIds; // Keeps track of available room IDs

            public RoomList()
            {
                rooms = new List<Room>();
                availableRoomIds = new Queue<int>();
            }

            public int GetNextRoomId()
            {
                if (availableRoomIds.Count > 0)
                {
                    return availableRoomIds.Dequeue(); // Reuse a previously freed room ID
                }
                else
                {
                    int roomId = rooms.Count + 1; // Generate a new room ID
                    return roomId;
                }
            }

            public void AddRoom(Room room)
            {
                rooms.Add(room);
            }

            public void RemoveRoom(Room room)
            {
                rooms.Remove(room);
                availableRoomIds.Enqueue(room.Id); // Add the freed room ID to the available IDs
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (true)
            {
                // Stop the server and close all client connections
                tcpListener.Stop();
                textBox1.Text += "Server stopped.\r\n";
            }
        }
    }
}
