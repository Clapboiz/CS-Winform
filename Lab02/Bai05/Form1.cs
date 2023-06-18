namespace Bai05;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        //Khởi tạo các cột trong listview.
        listView1.View = View.Details;
        listView1.Columns.Add("Tên");
        listView1.Columns.Add("Kích thước");
        listView1.Columns.Add("Đuôi mở rộng");
        listView1.Columns.Add("Ngày khởi tạo");
    }

    private void btnRead_Click(object sender, EventArgs e)
    {
        //FolderBrowserDialog là một hộp thoại cho phép người dùng chọn một thư mục.
        FolderBrowserDialog fbd = new FolderBrowserDialog();

        //Hiển thị hộp thoại và kiểm tra xem người dùng đã chọn một thư mục và nhấn OK hay chưa.
        if (fbd.ShowDialog() == DialogResult.OK)
        {
            textBox1.Text = fbd.SelectedPath;

            //Tạo một đối tượng DirectoryInfo với đường dẫn được chọn bởi người dùng.
            DirectoryInfo di = new DirectoryInfo(fbd.SelectedPath);
            //Lấy danh sách các tệp tin trong thư mục được chọn bởi người dùng và lưu trữ chúng trong một mảng các đối tượng FileInfo.
            FileInfo[] fiArr = di.GetFiles();

            //Lặp qua từng đối tượng FileInfo trong mảng fiArr.
            foreach (FileInfo file in fiArr)
            {
                ListViewItem item = new ListViewItem();
                //Đặt giá trị của thuộc tính Text của ListViewItem thành tên của tệp tin.
                item.Text = file.Name;

                //Thêm một mục con mới vào ListViewItem, đại diện cho đuôi mở rộng của tệp tin,
                //và đặt giá trị của nó thành đuôi mở rộng của tệp tin.
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = file.Length.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = file.Extension });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = file.CreationTime.ToString() });
                listView1.Items.Add(item);
            }
        }
    }

    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
