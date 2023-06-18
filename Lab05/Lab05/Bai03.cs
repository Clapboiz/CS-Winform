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

using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MailKit.Security;
using MimeKit;

namespace Lab05
{
    public partial class Bai03 : Form
    {
        private bool isLoggedIn = false;
        private ImapClient client;
        private string email;
        private string password;
        public Bai03()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;

        }

        //login
        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            string email = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            try
            {
                using (var client = new ImapClient())
                {
                    //await client.ConnectAsync("imap.gmail.com", 143, SecureSocketOptions.SslOnConnect);
                    client.Connect("127.0.0.1", 143, SecureSocketOptions.None);

                    await client.AuthenticateAsync(email, password);

                    var inbox = client.Inbox;
                    await inbox.OpenAsync(FolderAccess.ReadOnly);

                    label5.Text = inbox.Count.ToString();
                    label6.Text = inbox.Recent.ToString();

                    for (int i = 0; i < inbox.Count; i++)
                    {
                        var message = await inbox.GetMessageAsync(i);

                        ListViewItem name = new ListViewItem(message.Subject);

                        ListViewItem.ListViewSubItem from = new ListViewItem.ListViewSubItem(name, message.From.ToString());
                        name.SubItems.Add(from);

                        ListViewItem.ListViewSubItem date = new ListViewItem.ListViewSubItem(name, message.Date.Date.ToString());
                        name.SubItems.Add(date);

                        listView1.Items.Add(name);
                        button2.Enabled = true;
                        button3.Enabled = true;
                    }

                    client.Disconnect(true);
                    isLoggedIn = true;
                }
            }
            catch (SocketException ex)
            {
                MessageBox.Show($"Lỗi kết nối máy chủ IMAP. Chi tiết lỗi: {ex.Message}");
            }

            button1.Enabled = true;
        }


        private void Bai03_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Email", 200);
            listView1.Columns.Add("From", 100);
            listView1.Columns.Add("Thời gian", 100);
            listView1.View = View.Details;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;

            if (client != null)
            {
                await client.DisconnectAsync(true);
                client = null;
            }

            textBox1.Clear();
            textBox2.Clear();
            label5.Text = "";
            label6.Text = "";
            listView1.Items.Clear();
            button1.Enabled = true;

            MessageBox.Show("Đã đăng xuất khỏi tài khoản email.");
        }

        private void Bai03_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (client != null && client.IsConnected)
            {
                client.Disconnect(true);
                client = null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai03_Compose frmCompose = new Bai03_Compose(email,password);
            frmCompose.Show();
        }
    }
}
