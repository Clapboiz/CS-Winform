namespace LAB2
{
    partial class Bai2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            mssv = new TextBox();
            hoten = new TextBox();
            tel = new TextBox();
            toan = new TextBox();
            van = new TextBox();
            trungbinh = new TextBox();
            listView1 = new ListView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(16, 48);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(100, 35);
            button1.TabIndex = 0;
            button1.Text = "Read";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(16, 103);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(100, 35);
            button2.TabIndex = 1;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // mssv
            // 
            mssv.Location = new Point(124, 220);
            mssv.Margin = new Padding(4, 5, 4, 5);
            mssv.Name = "mssv";
            mssv.Size = new Size(132, 27);
            mssv.TabIndex = 4;
            // 
            // hoten
            // 
            hoten.Location = new Point(124, 260);
            hoten.Margin = new Padding(4, 5, 4, 5);
            hoten.Name = "hoten";
            hoten.Size = new Size(132, 27);
            hoten.TabIndex = 5;
            // 
            // tel
            // 
            tel.Location = new Point(124, 300);
            tel.Margin = new Padding(4, 5, 4, 5);
            tel.Name = "tel";
            tel.Size = new Size(132, 27);
            tel.TabIndex = 6;
            // 
            // toan
            // 
            toan.Location = new Point(124, 342);
            toan.Margin = new Padding(4, 5, 4, 5);
            toan.Name = "toan";
            toan.Size = new Size(132, 27);
            toan.TabIndex = 7;
            // 
            // van
            // 
            van.Location = new Point(124, 382);
            van.Margin = new Padding(4, 5, 4, 5);
            van.Name = "van";
            van.Size = new Size(132, 27);
            van.TabIndex = 8;
            // 
            // trungbinh
            // 
            trungbinh.Location = new Point(124, 422);
            trungbinh.Margin = new Padding(4, 5, 4, 5);
            trungbinh.Name = "trungbinh";
            trungbinh.Size = new Size(132, 27);
            trungbinh.TabIndex = 9;
            // 
            // listView1
            // 
            listView1.Location = new Point(124, 48);
            listView1.Margin = new Padding(4, 5, 4, 5);
            listView1.Name = "listView1";
            listView1.Size = new Size(160, 147);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button3
            // 
            button3.Location = new Point(16, 162);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(100, 35);
            button3.TabIndex = 11;
            button3.Text = "Write";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 231);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 12;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 271);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 13;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 311);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 14;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 352);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 15;
            label4.Text = "Math";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 392);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 16;
            label5.Text = "Literature";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 432);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 17;
            label6.Text = "Average";
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 525);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(listView1);
            Controls.Add(trungbinh);
            Controls.Add(van);
            Controls.Add(toan);
            Controls.Add(tel);
            Controls.Add(hoten);
            Controls.Add(mssv);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Bai2";
            Text = "Bai2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox mssv;
        private TextBox hoten;
        private TextBox tel;
        private TextBox toan;
        private TextBox van;
        private TextBox trungbinh;
        private ListView listView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}