using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FtpWebRequest request = null;
        FtpWebResponse response = null;
        Stream ftpStream = null;
        int length = 1024;

        private List<string> ListFiles()
        {
            try
            {
                request = (FtpWebRequest)WebRequest.Create(txt_server.Text);
                request.Method = WebRequestMethods.Ftp.ListDirectory;

                request.Credentials = new NetworkCredential(txt_username.Text, txt_password.Text);
                response = (FtpWebResponse)request.GetResponse();
                ftpStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(ftpStream);
                string names = reader.ReadToEnd();

                reader.Close();
                response.Close();
                request = null;

                return names.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void UploadFile(string filePath)
        {
            try
            {
                // Get the file name from the path
                string fileName = Path.GetFileName(filePath);

                // Create the FTP request
                request = (FtpWebRequest)WebRequest.Create(txt_server.Text + "/" + fileName);
                request.Method = WebRequestMethods.Ftp.UploadFile;

                // Set the credentials
                request.Credentials = new NetworkCredential(txt_username.Text, txt_password.Text);

                // Read the file into a byte array
                byte[] fileContents;
                using (StreamReader sourceStream = new StreamReader(filePath))
                {
                    fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
                }

                // Upload the file
                ftpStream = request.GetRequestStream();
                ftpStream.Write(fileContents, 0, fileContents.Length);
                ftpStream.Close();

                // Clean up
                request = null;
                MessageBox.Show("File uploaded successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error uploading file: " + ex.Message);
            }
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            string filePath = txt_file.Text;
            UploadFile(filePath);
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.txt_file.Text = openFileDialog1.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Download()
        {
            try
            {
                string str = listView1.SelectedItems[0].Text;
                request = (FtpWebRequest)WebRequest.Create(txt_server.Text + "/" + str);
                request.Credentials = new NetworkCredential(txt_username.Text, txt_password.Text);

                request.UseBinary = true;
                request.UsePassive = true;
                request.KeepAlive = true;
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                response = (FtpWebResponse)request.GetResponse();
                ftpStream = response.GetResponseStream();
                saveFileDialog1.FileName = str;
                DialogResult result = saveFileDialog1.ShowDialog();
                byte[] byteBuffer = new byte[length];
                int bytesRead = ftpStream.Read(byteBuffer, 0, length);
                if (result == DialogResult.OK)
                {
                    FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                    try
                    {
                        while (bytesRead > 0)
                        {
                            fs.Write(byteBuffer, 0, bytesRead);
                            bytesRead = ftpStream.Read(byteBuffer, 0, length);
                        }
                        MessageBox.Show("Downloaded file successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fs.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                ftpStream.Close();
                response.Close();
                request = null;
            }
            catch
            {
                MessageBox.Show("Select a file before downloading!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            Download();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Download();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            List<string> listFile = ListFiles();
            for (int i = 0; i < listFile.Count; i++)
            {
                listView1.Items.Add(listFile[i]);
            }
        }
    }
}