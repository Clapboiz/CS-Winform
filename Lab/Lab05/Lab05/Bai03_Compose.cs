using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Mail;
using System.Net;
namespace Lab05
{
    public partial class Bai03_Compose : Form
    {
        private string email;
        private string password;
        public Bai03_Compose(string _email, string _password)
        {
            InitializeComponent();
            this.email = _email;
            this.password = _password;
            tbEmail.Text = this.email;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        //send email
        private void button1_Click(object sender, EventArgs e)
        {
            using (SmtpClient _smtpClient = new SmtpClient("127.0.0.1"))
            {
                string mailFrom = this.email;
                if (string.IsNullOrEmpty(mailFrom))
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ email của bạn.");
                    return;
                }

                string mailTo = tbTo.Text.Trim();
                if (string.IsNullOrEmpty(mailTo))
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ email người nhận.");
                    return;
                }

                string password = this.password;
                var basicCredential = new NetworkCredential(mailFrom, password);
                using (MailMessage message = new MailMessage())
                {
                    MailAddress fromAddress = new MailAddress(mailFrom);
                    _smtpClient.UseDefaultCredentials = false;
                    _smtpClient.Credentials = basicCredential;

                    message.From = fromAddress;
                    message.Subject = tbSubject.Text.ToString().Trim();
                    //Set IsBodyHtml to true means you can send HTML email
                    message.IsBodyHtml = true;
                    message.Body = tbBody.Text.ToString();
                    message.To.Add(mailTo);

                    try
                    {
                        _smtpClient.Send(message);
                    }
                    catch (Exception _ex)
                    {
                        MessageBox.Show($"Error: {_ex}");
                    }
                }
            }
        }
    }
}
