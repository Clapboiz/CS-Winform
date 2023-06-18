using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Imap;
using MailKit;
using MailKit.Search;
using System.Windows.Forms;
using System.Threading;
using MailKit.Security;
using System.Linq.Expressions;

namespace Lab05
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
            lvlDetailEmail.Columns.Add("Subject", 200);
            lvlDetailEmail.Columns.Add("From", 200);
            lvlDetailEmail.Columns.Add("Date", 200);
            lvlDetailEmail.View = View.Details;
            txtPassword.Clear();
            txtPassword.PasswordChar = '*';
        }

        void ReadMail()
        {
            try
            {
                using (var client = new ImapClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    client.Connect("localhost", 993, true);

                    client.Authenticate(txtEmail.Text, txtPassword.Text);
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);

                    lblTotal.Text = inbox.Count.ToString();
                    lblRecent.Text = inbox.Recent.ToString();

                    for (int i = 0; i < inbox.Count; i++)
                    {
                        var message = inbox.GetMessage(i);

                        ListViewItem item = new ListViewItem();
                        item.Text = message.Subject;
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = message.From.ToString() });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = message.Date.Date.ToString() });
                        lvlDetailEmail.Items.Add(item);
                    }
                }                
            }
            catch
            {
                MessageBox.Show("Kiểm tra user và password!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtEmail.Text != string.Empty) &&(txtPassword.Text != string.Empty))
            {
                ReadMail();
            }
            else if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Điền user!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Điền password!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
