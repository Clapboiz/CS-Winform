namespace Bai03
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TienChuyen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GiaDoi = new System.Windows.Forms.TextBox();
            this.TienDoi = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuyển đổi tiền tệ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Chuyển đổi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CD_Click);
            // 
            // TienChuyen
            // 
            this.TienChuyen.Location = new System.Drawing.Point(257, 70);
            this.TienChuyen.Name = "TienChuyen";
            this.TienChuyen.Size = new System.Drawing.Size(159, 27);
            this.TienChuyen.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số tiền đã đổi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số tiền cần chuyển đổi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tỷ giá quy đổi";
            // 
            // GiaDoi
            // 
            this.GiaDoi.Location = new System.Drawing.Point(207, 325);
            this.GiaDoi.Name = "GiaDoi";
            this.GiaDoi.Size = new System.Drawing.Size(209, 27);
            this.GiaDoi.TabIndex = 6;
            // 
            // TienDoi
            // 
            this.TienDoi.Location = new System.Drawing.Point(207, 261);
            this.TienDoi.Name = "TienDoi";
            this.TienDoi.Size = new System.Drawing.Size(209, 27);
            this.TienDoi.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "EUR (Euro)",
            "USD (Đô la Mỹ)",
            "GBP (Bảng Anh)",
            "SGD (Đô-la Singapore)",
            "JPY (Yên Nhật)",
            "VND (Việt Nam Đồng)"});
            this.comboBox1.Location = new System.Drawing.Point(454, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "EUR (Euro)",
            "USD (Đô la Mỹ)",
            "GBP (Bảng Anh)",
            "SGD (Đô-la Singapore)",
            "JPY (Yên Nhật)",
            "VND (Việt Nam Đồng)"});
            this.comboBox2.Location = new System.Drawing.Point(454, 261);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 28);
            this.comboBox2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TienDoi);
            this.Controls.Add(this.GiaDoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TienChuyen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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