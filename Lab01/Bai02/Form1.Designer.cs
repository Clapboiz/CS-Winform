namespace Bai02
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
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Thoát = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Vào Số Nguyên Từ 0 Đến 9";
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(353, 56);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(125, 27);
            this.Txt1.TabIndex = 1;
            this.Txt1.TextChanged += new System.EventHandler(this.Txt1_TextChanged);
            // 
            // Txt2
            // 
            this.Txt2.Location = new System.Drawing.Point(100, 237);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(125, 27);
            this.Txt2.TabIndex = 3;
            this.Txt2.TextChanged += new System.EventHandler(this.Txt2_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(626, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(626, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 5;
            this.button3.Text = "Đọc";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Doc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kết Quả";
            // 
            // Thoát
            // 
            this.Thoát.Location = new System.Drawing.Point(626, 187);
            this.Thoát.Name = "Thoát";
            this.Thoát.Size = new System.Drawing.Size(94, 29);
            this.Thoát.TabIndex = 8;
            this.Thoát.Text = "Thoát";
            this.Thoát.UseVisualStyleBackColor = true;
            this.Thoát.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 645);
            this.Controls.Add(this.Thoát);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Txt1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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