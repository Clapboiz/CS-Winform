using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        public string filename;

        [Serializable()]

        public class sinhvien
        {
            public string id, name, phone;
            public float toan, van;
            // method to calculate the average score
            public float dtb(float a, float b)
            {
                return (a + b) / 2;
            }
        }

        // button to choose the file to save input data
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            filename = sfd.FileName;
        }

        // button to add a student to the list view and save the student to the file
        private void button2_Click(object sender, EventArgs e)
        {
            // create a new sinhvien object with the input values
            sinhvien sv = new sinhvien();
            sv.id = mssv.Text;
            sv.name = hoten.Text;
            sv.phone = tel.Text;
            sv.toan = float.Parse(toan.Text);
            sv.van = float.Parse(van.Text);

            // add the student to the list view
            ListViewItem item = new ListViewItem(sv.id);
            item.SubItems.Add(sv.name);
            item.SubItems.Add(sv.phone);
            item.SubItems.Add(sv.toan.ToString());
            item.SubItems.Add(sv.van.ToString());
            listView1.Items.Add(item);

            // save the student object to the file using BinaryFormatter
            FileStream fs = new FileStream(filename, FileMode.Append);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, sv);

            MessageBox.Show("Data added to file successful!", "Information");

            // clear the input fields
            mssv.Clear();
            hoten.Clear();
            tel.Clear();
            toan.Clear();
            van.Clear();

            // close the file stream
            fs.Close();
        }

        // button to read the student data from the file and display in the list view
        private void button3_Click(object sender, EventArgs e)
        {

            List<string> list = new List<string>();


            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();

            //The while loop continues to deserialize each sinhvien object from the fs stream until the end of the file is reached.
            while (listView1.Items.Count > 0)
            {
                listView1.Items[0].Remove();
            }


            while (fs.Position != fs.Length)
            {

                sinhvien sv = (sinhvien)bf.Deserialize(fs);
                //Creates a new ListViewItem object called "item" with the values of the properties of the "sv" sinhvien object, and adds it to the "listView1" ListView control
                ListViewItem item = new ListViewItem(sv.id);
                item.SubItems.Add(sv.name);
                item.SubItems.Add(sv.phone);
                item.SubItems.Add(sv.toan.ToString());
                item.SubItems.Add(sv.van.ToString());
                item.SubItems.Add(sv.dtb(sv.toan, sv.van).ToString());
                listView1.Items.Add(item);

                //Adds the "output" string to the "list" list of strings.
                string output = $"{sv.id}\n{sv.name}\n{sv.phone}\n{sv.toan}\n{sv.van}\n{sv.dtb(sv.toan, sv.van)}\n\n";
                list.Add(output);
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();

            //Uses a foreach loop to iterate over each string in the "list" list of strings and write it to the file using the "_writer" StreamWriter object.
            using (FileStream _fs = new FileStream(sfd.FileName, FileMode.Append))
            using (StreamWriter _writer = new StreamWriter(_fs))
                foreach (string sv in list)
                    _writer.WriteLine(sv);

            fs.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
