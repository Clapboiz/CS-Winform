namespace Menu
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
            Bai1 = new Button();
            Bai2 = new Button();
            Bai3 = new Button();
            Bai4 = new Button();
            Bai5 = new Button();
            SuspendLayout();
            // 
            // Bai1
            // 
            Bai1.Location = new Point(223, 192);
            Bai1.Name = "Bai1";
            Bai1.Size = new Size(94, 29);
            Bai1.TabIndex = 0;
            Bai1.Text = "Bài 01";
            Bai1.UseVisualStyleBackColor = true;
            Bai1.Click += Bai01_Click;
            // 
            // Bai2
            // 
            Bai2.Location = new Point(357, 192);
            Bai2.Name = "Bai2";
            Bai2.Size = new Size(94, 29);
            Bai2.TabIndex = 1;
            Bai2.Text = "Bài 02";
            Bai2.UseVisualStyleBackColor = true;
            Bai2.Click += Bai02_Click;
            // 
            // Bai3
            // 
            Bai3.Location = new Point(475, 192);
            Bai3.Name = "Bai3";
            Bai3.Size = new Size(94, 29);
            Bai3.TabIndex = 2;
            Bai3.Text = "Bài 03";
            Bai3.UseVisualStyleBackColor = true;
            Bai3.Click += Bai3_Click;
            // 
            // Bai4
            // 
            Bai4.Location = new Point(287, 248);
            Bai4.Name = "Bai4";
            Bai4.Size = new Size(94, 29);
            Bai4.TabIndex = 3;
            Bai4.Text = "Bài 04";
            Bai4.UseVisualStyleBackColor = true;
            Bai4.Click += Bai4_Click;
            // 
            // Bai5
            // 
            Bai5.Location = new Point(409, 248);
            Bai5.Name = "Bai5";
            Bai5.Size = new Size(94, 29);
            Bai5.TabIndex = 4;
            Bai5.Text = "Bài 05";
            Bai5.UseVisualStyleBackColor = true;
            Bai5.Click += Bai5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Bai5);
            Controls.Add(Bai4);
            Controls.Add(Bai3);
            Controls.Add(Bai2);
            Controls.Add(Bai1);
            Name = "Form1";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button Bai1;
        private Button Bai2;
        private Button Bai3;
        private Button Bai4;
        private Button Bai5;
    }
}