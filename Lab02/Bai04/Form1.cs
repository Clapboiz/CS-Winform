using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Bai04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        List<string> lines = new List<string>();

        public class Student
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public double Score1 { get; set; }
            public double Score2 { get; set; }
            public double AverageScore { get; set; }
        }

        private List<Student> CreateStudentList(List<string> lines)
        {
            List<Student> students = new List<Student>();

            for (int i = 0; i < lines.Count; i += 5)
            {
                Student student = new Student
                {
                    ID = lines[i],
                    Name = lines[i + 1],
                    Score1 = double.Parse(lines[i + 2]),
                    Score2 = double.Parse(lines[i + 3])
                };

                student.AverageScore = (student.Score1 + student.Score2) / 2;

                students.Add(student);
            }

            return students;
        }

        private double CalculateAverageScore(List<string> lines)
        {
            double sum = 0;
            int count = 0;
            foreach (string line in lines)
            {
                if (double.TryParse(line, out double score))
                {
                    sum += score;
                    count++;
                }
            }
            if (count == 0)
            {
                return 0;
            }
            else
            {
                return sum / count;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                FileStream fs = new FileStream(filePath, FileMode.Open);

                object data = bf.Deserialize(fs);
                if (data is string)
                {
                    RichTextBox1.Text = (string)data;
                    MessageBox.Show("Data read from file successfully.");

                    // Convert the content of RichTextBox1 to a list of strings
                    List<string> lines = new List<string>(RichTextBox1.Lines);

                    // Create a list of students
                    List<Student> students = CreateStudentList(lines);

                    // Display the list of students and their average scores
                    RichTextBox1.Clear();
                    foreach (Student student in students)
                    {
                        RichTextBox1.AppendText(student.ID + "\t" + student.Name + "\t" + student.Score1 + "\t" + student.Score2 + "\t" + student.AverageScore + "\n");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid file format.");
                }

                fs.Close();
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            SaveFileDialog sfd = new SaveFileDialog();

            int line = RichTextBox1.Lines.Length;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                RichTextBox1.Lines[0] = "5";
                string filePath = sfd.FileName;
                FileStream fs = new FileStream(filePath, FileMode.Create);

                bf.Serialize(fs, RichTextBox1.Text);
                MessageBox.Show("Data saved to file successfully.");

                fs.Close();
            }
        }
    }
}