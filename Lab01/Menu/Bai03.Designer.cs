namespace Bai03
{
    partial class Bai3
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            TienChuyen = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            GiaDoi = new TextBox();
            TienDoi = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 21);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 0;
            label1.Text = "Chuyển đổi tiền tệ";
            // 
            // button1
            // 
            button1.Location = new Point(93, 152);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Chuyển đổi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CD_Click;
            // 
            // TienChuyen
            // 
            TienChuyen.Location = new Point(257, 70);
            TienChuyen.Name = "TienChuyen";
            TienChuyen.Size = new Size(159, 27);
            TienChuyen.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 261);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 3;
            label2.Text = "Số tiền đã đổi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 73);
            label3.Name = "label3";
            label3.Size = new Size(158, 20);
            label3.TabIndex = 4;
            label3.Text = "Số tiền cần chuyển đổi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 332);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 5;
            label4.Text = "Tỷ giá quy đổi";
            // 
            // GiaDoi
            // 
            GiaDoi.Location = new Point(207, 325);
            GiaDoi.Name = "GiaDoi";
            GiaDoi.Size = new Size(209, 27);
            GiaDoi.TabIndex = 6;
            // 
            // TienDoi
            // 
            TienDoi.Location = new Point(207, 261);
            TienDoi.Name = "TienDoi";
            TienDoi.Size = new Size(209, 27);
            TienDoi.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "EUR (Euro)", "USD (Đô la Mỹ)", "GBP (Bảng Anh)", "SGD (Đô-la Singapore)", "JPY (Yên Nhật)", "VND (Việt Nam Đồng)" });
            comboBox1.Location = new Point(454, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "EUR (Euro)", "USD (Đô la Mỹ)", "GBP (Bảng Anh)", "SGD (Đô-la Singapore)", "JPY (Yên Nhật)", "VND (Việt Nam Đồng)" });
            comboBox2.Location = new Point(454, 261);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 9;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(TienDoi);
            Controls.Add(GiaDoi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TienChuyen);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Bai3";
            Text = "Bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox TienChuyen;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox GiaDoi;
        private TextBox TienDoi;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}