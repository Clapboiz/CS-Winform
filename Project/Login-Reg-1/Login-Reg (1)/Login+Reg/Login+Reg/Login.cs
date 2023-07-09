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


namespace Login_Reg
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private const int SALTSIZE = 128; // Kích thước của salt là 16 byte
        private const int IVSIZE = 128; // Kích thước của iv là 16 byte

        private const int KEYSIZE = 256;



        private void btn_login_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM USER_PASWE WHERE Username = @username and [PASSW] = @password";
            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-24Q4TSL0\SQLEXPRESS;Initial Catalog=DATA_REGISTER;Integrated Security=True"))
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@username", txt_username.Text.Trim());
                    command.Parameters.AddWithValue("@password", txt_pasw.Text.Trim());
                    using (SqlDataAdapter sda = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            string username = dt.Rows[0]["Username"].ToString();
                            SaveUserLoginInfo(username);
                            new App().Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("No Account available with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }


        private void SaveUserLoginInfo(string username)
        {
            string connectionString = @"Data Source=LAPTOP-24Q4TSL0\SQLEXPRESS;Initial Catalog=DATA_REGISTER;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO UserLoginInfo (Username, PASSW, ENCRYPT_PASSW, SALT, LastLogin) VALUES (@username, @password, @ENCRYPT_PASSW, @SALT, @lastLogin)";
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
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

                    insertCommand.Parameters.AddWithValue("@username", username);
                    insertCommand.Parameters.AddWithValue("@password", passwordBytes);
                    insertCommand.Parameters.AddWithValue("@ENCRYPT_PASSW", base64Password);
                    insertCommand.Parameters.AddWithValue("@SALT", Convert.ToBase64String(salt));
                    insertCommand.Parameters.AddWithValue("@lastLogin", DateTime.Now);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

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

            using var ms = new MemoryStream();
            using var cs = new CryptoStream(ms, rij.CreateEncryptor(), CryptoStreamMode.Write);

            using (var bw = new BinaryWriter(cs))
            {
                bw.Write(data);
            }

            return ms.ToArray();
        }


        private static string DecryptPassword(string encryptedPassword, string password)
        {
            byte[] encryptedPasswordBytes = Convert.FromBase64String(encryptedPassword);
            byte[] salt = new byte[SALTSIZE];
            Array.Copy(encryptedPasswordBytes, 0, salt, 0, SALTSIZE);
            byte[] iv = new byte[IVSIZE];
            Array.Copy(encryptedPasswordBytes, SALTSIZE, iv, 0, IVSIZE);
            byte[] encryptedData = new byte[encryptedPasswordBytes.Length - SALTSIZE - IVSIZE];
            Array.Copy(encryptedPasswordBytes, SALTSIZE + IVSIZE, encryptedData, 0, encryptedData.Length);
            byte[] decryptedData = Decrypt(encryptedData, password, salt, iv);
            return Encoding.UTF8.GetString(decryptedData);
        }

        public static byte[] Decrypt(byte[] data, string password, byte[] salt, byte[] iv)
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

            using var ms = new MemoryStream(data);
            using var cs = new CryptoStream(ms, rij.CreateDecryptor(), CryptoStreamMode.Read);

            using var br = new BinaryReader(cs);
            return br.ReadBytes(data.Length);
        }

        private void btn_show_pasw_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_show_pasw.Checked)
            {
                txt_pasw.PasswordChar = '\0';
            }

            else
            {
                txt_pasw.PasswordChar = '*';
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

    }
}