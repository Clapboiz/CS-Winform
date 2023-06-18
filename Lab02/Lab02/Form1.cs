namespace Lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng OpenFileDialog để cho phép người dùng chọn tệp tin
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            // Tạo một đối tượng FileStream để mở tệp tin trong chế độ đọc 
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            // Tạo một đối tượng StreamReader để đọc nội dung của tệp tin
            StreamReader sr = new StreamReader(fs);
            // Đọc toàn bộ nội dung của tệp tin bằng phương thức ReadToEnd() của đối tượng StreamReader
            string content = sr.ReadToEnd();
            RichTextBox1.Text = content;
            fs.Close();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {

            // Tạo một đối tượng SaveFileDialog để
            // cho phép người dùng đặt tên và chọn vị trí để lưu tệp tin mới
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();

            // Show messagebox
            string msg = "Các kí tự thêm vào Text Box sẽ được viết hoa khi ghi vào file.";
            MessageBox.Show(msg);

            // Ghi xuong file
            // Tạo một đối tượng StreamWriter để ghi nội dung vào tệp tin mới
            StreamWriter sw = new StreamWriter(sfd.FileName);
            string content = RichTextBox1.Text;
            content = content.ToUpper();
            sw.Write(content);
            sw.Close();
        }
    }
}