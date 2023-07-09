namespace Bai02
{
    partial class Bai2
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
            Txt1 = new TextBox();
            Txt2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            Thoát = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 59);
            label1.Name = "label1";
            label1.Size = new Size(226, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập Vào Số Nguyên Từ 0 Đến 9";
            // 
            // Txt1
            // 
            Txt1.Location = new Point(353, 56);
            Txt1.Name = "Txt1";
            Txt1.Size = new Size(125, 27);
            Txt1.TabIndex = 1;
            Txt1.TextChanged += Txt1_TextChanged;
            // 
            // Txt2
            // 
            Txt2.Location = new Point(100, 237);
            Txt2.Name = "Txt2";
            Txt2.Size = new Size(125, 27);
            Txt2.TabIndex = 3;
            Txt2.TextChanged += Txt2_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(626, 122);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Xoa_Click;
            // 
            // button3
            // 
            button3.Location = new Point(626, 59);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 5;
            button3.Text = "Đọc";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Doc_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 196);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 6;
            label2.Text = "Kết Quả";
            // 
            // Thoát
            // 
            Thoát.Location = new Point(626, 187);
            Thoát.Name = "Thoát";
            Thoát.Size = new Size(94, 29);
            Thoát.TabIndex = 8;
            Thoát.Text = "Thoát";
            Thoát.UseVisualStyleBackColor = true;
            Thoát.Click += Thoat_Click;
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 645);
            Controls.Add(Thoát);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Txt2);
            Controls.Add(Txt1);
            Controls.Add(label1);
            Name = "Bai2";
            Text = "Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Txt1;
        private TextBox Txt2;
        private Button button2;
        private Button button3;
        private Label label2;
        private Button Thoát;
    }
}