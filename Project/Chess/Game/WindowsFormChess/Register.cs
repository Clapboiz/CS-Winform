using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;

namespace Sakk_Alkalmazás_2._0
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_Click_Register(object sender, EventArgs e)
        {
            if (txt_username.Text == "" && txt_pasw.Text == "" && txt_confirm_pasw.Text == "")
            {
                MessageBox.Show("Username and password are empty!", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_confirm_pasw.Text == txt_pasw.Text)
            {
                // Tạo một mảng byte chứa mật khẩu người dùng
                byte[] passwordBytes = Encoding.UTF8.GetBytes(txt_pasw.Text);

                // Tạo salt và iv
                byte[] salt = new byte[SALTSIZE / 8];
                using (var rng = new RNGCryptoServiceProvider())
                {
                    rng.GetBytes(salt);
                }

                byte[] iv = new byte[IVSIZE / 8];
                using (var rng = new RNGCryptoServiceProvider())
                {
                    rng.GetBytes(iv);
                }

                // Mã hóa mật khẩu sử dụng salt và iv
                byte[] encryptedPassword = Encrypt(passwordBytes, txt_pasw.Text, salt, iv);

                // Chuyển đổi mật khẩu đã được mã hóa sang chuỗi base64
                string base64Password = Convert.ToBase64String(encryptedPassword);

                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-EGMVE44L\SQLEXPRESS;Initial Catalog=DATA_REGISTER;Integrated Security=True"))
                {
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@username", txt_username.Text.Trim());
                        command.Parameters.AddWithValue("@password", txt_pasw.Text.Trim());
                        command.Parameters.AddWithValue("@ENCRYPT_PASSW", base64Password);
                        command.Parameters.AddWithValue("@SALT", Convert.ToBase64String(salt));
                        con.Open();
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Registration failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                //MessageBox.Show("Your account has been Successfully Created", "Regestration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_username.Text = "";
                txt_pasw.Text = "";
                txt_confirm_pasw.Text = "";
            }

            else
            {
                MessageBox.Show("Password does not match, Please Re-enter", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_pasw.Text = "";
                txt_confirm_pasw.Text = "";
                txt_pasw.Focus();
            }
        }

        private const int SALTSIZE = 128; // Kích thước của salt là 16 byte
        private const int IVSIZE = 128; // Kích thước của iv là 16 byte

        private const int KEYSIZE = 256;
        string query = "INSERT INTO USER_PASWE (Username, [PASSW], ENCRYPT_PASSW, SALT) VALUES (@username, @password, @ENCRYPT_PASSW, @SALT)";


        public static byte[] Encrypt(byte[] data, string password, byte[] salt, byte[] iv)
        {
            using var rij = new RijndaelManaged()
            {
                KeySize = KEYSIZE,
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7
            };

            using var rfc = new Rfc2898DeriveBytes(password, salt);
            rij.Key = rfc.GetBytes(KEYSIZE / 8);
            rij.IV = iv;

            MemoryStream memoryStream = new MemoryStream();

            using var ms = new MemoryStream();
            using var cs = new CryptoStream(ms, rij.CreateEncryptor(), CryptoStreamMode.Write);

            using (var bw = new BinaryWriter(cs))
            {
                bw.Write(data);
            }

            return ms.ToArray();
        }

        private void btn_show_pasw_Click(object sender, EventArgs e)
        {
            if (btn_show_pasw.Checked)
            {
                txt_pasw.PasswordChar = '\0';
                txt_confirm_pasw.PasswordChar = '\0';
            }

            else
            {
                txt_pasw.PasswordChar = '*';
                txt_confirm_pasw.PasswordChar = '*';
            }
        }

        private void btn_back_login_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }

}
