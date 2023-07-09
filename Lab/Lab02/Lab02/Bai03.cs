namespace Bai03
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            //Tạo một đối tượng OpenFileDialog để cho phép người dùng chọn tập tin cần đọc.
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            //Tạo một đối tượng FileStream để đọc tập tin được chọn.
            //Đối tượng này được tạo với một chế độ mở tệp tin
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);

            //Tạo một đối tượng StreamReader để đọc dữ liệu từ đối tượng FileStream.
            //Phương thức ReadToEnd() được sử dụng để đọc toàn bộ nội dung của tệp tin và lưu trữ vào chuỗi "content".
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            RichTextBox1.Text = content;


            fs.Close();
        }

        public static string Calculate(string str)
        {
            int position = -1;
            char op = ' ';
            for (int i = 0; i < str.Length; ++i)
            {
                //Tìm vị trí của toán tử đầu tiên (+, -, *, hoặc /) trong chuỗi đầu vào bằng cách lặp qua từng ký tự
                //trong chuỗi cho đến khi tìm thấy một trong các toán tử này.
                //Vị trí của toán tử được lưu trữ trong biến "position", và toán tử đó được lưu trữ trong biến "op".
                if (str[i] == '+' || str[i] == '-' || str[i] == '*' || str[i] == '/')
                {
                    position = i;
                    op = str[i];
                    break;
                }
            }

            //Tách một biểu thức toán học có chứa hai toán hạng và một toán tử
            //ra khỏi chuỗi "str" và gán giá trị của hai toán hạng vào biến "a" và "b".
            int a = int.Parse(str.Substring(0, position));
            int b = int.Parse(str.Substring(position + 1));
            int result = 0;
            switch (op)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    result = a / b;
                    break;
            }
            return result.ToString();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            //Đếm số dòng trong RichTextBox1 bằng cách đếm số phần tử trong mảng dòng của RichTextBox1.
            int lines = RichTextBox1.Lines.Length;

            //Hiển thị hộp thoại SaveFileDialog để người dùng có thể chọn vị trí và tên tệp tin để lưu dữ liệu.
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //Nếu người dùng chọn tệp tin và nhấp vào nút Save trong SaveFileDialog, 
                    //phương thức sẽ tạo một đối tượng StreamWriter để ghi dữ liệu vào tệp tin được chọn.
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        for (int j = 0; j < lines; j++)
                        {
                            //Với mỗi dòng trong RichTextBox1, phương thức sẽ lấy nội dung của dòng đó và tính giá trị của biểu thức toán học
                            //bằng phương thức Calculate. Sau đó, phương thức sẽ ghi nội dung và giá trị tính toán vào tệp tin.
                            string content = RichTextBox1.Lines[j];
                            string result = $"{content} = {Calculate(content)}";
                            sw.WriteLine(result);
                        }
                        // Close the stream writer.
                        sw.Close();
                        MessageBox.Show("The file has been saved successfully!", "Message");
                    }
                }
            }
        }
    }
}