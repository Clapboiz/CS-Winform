﻿namespace Lab02
{
    partial class Bai01
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
            button1 = new Button();
            button2 = new Button();
            RichTextBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(49, 122);
            button1.Name = "button1";
            button1.Size = new Size(123, 29);
            button1.TabIndex = 0;
            button1.Text = "ĐỌC FILE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnRead_Click;
            // 
            // button2
            // 
            button2.Location = new Point(49, 189);
            button2.Name = "button2";
            button2.Size = new Size(123, 29);
            button2.TabIndex = 1;
            button2.Text = "GHI FILE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnWrite_Click;
            // 
            // RichTextBox1
            // 
            RichTextBox1.Location = new Point(211, 42);
            RichTextBox1.Multiline = true;
            RichTextBox1.Name = "RichTextBox1";
            RichTextBox1.Size = new Size(327, 288);
            RichTextBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RichTextBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox RichTextBox1;
    }
}