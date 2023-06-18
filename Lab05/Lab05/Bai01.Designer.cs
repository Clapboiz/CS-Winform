namespace Lab05
{
    partial class Bai01
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
            this.btn_send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_from = new System.Windows.Forms.TextBox();
            this.txt_to = new System.Windows.Forms.TextBox();
            this.txt_passw = new System.Windows.Forms.TextBox();
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.richTextBox_body = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(53, 55);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(83, 29);
            this.btn_send.TabIndex = 0;
            this.btn_send.Text = "SEND";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Subject:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Body:";
            // 
            // txt_from
            // 
            this.txt_from.Location = new System.Drawing.Point(225, 31);
            this.txt_from.Name = "txt_from";
            this.txt_from.Size = new System.Drawing.Size(225, 27);
            this.txt_from.TabIndex = 6;
            // 
            // txt_to
            // 
            this.txt_to.Location = new System.Drawing.Point(225, 82);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(225, 27);
            this.txt_to.TabIndex = 7;
            // 
            // txt_passw
            // 
            this.txt_passw.Location = new System.Drawing.Point(560, 33);
            this.txt_passw.Name = "txt_passw";
            this.txt_passw.PasswordChar = '*';
            this.txt_passw.Size = new System.Drawing.Size(190, 27);
            this.txt_passw.TabIndex = 8;
            // 
            // txt_subject
            // 
            this.txt_subject.Location = new System.Drawing.Point(167, 171);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(583, 27);
            this.txt_subject.TabIndex = 9;
            // 
            // richTextBox_body
            // 
            this.richTextBox_body.Location = new System.Drawing.Point(167, 212);
            this.richTextBox_body.Name = "richTextBox_body";
            this.richTextBox_body.Size = new System.Drawing.Size(583, 191);
            this.richTextBox_body.TabIndex = 10;
            this.richTextBox_body.Text = "";
            // 
            // Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox_body);
            this.Controls.Add(this.txt_subject);
            this.Controls.Add(this.txt_passw);
            this.Controls.Add(this.txt_to);
            this.Controls.Add(this.txt_from);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_send);
            this.Name = "Bai01";
            this.Text = "Bai01";
            this.Load += new System.EventHandler(this.Bai01_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_send;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_from;
        private TextBox txt_to;
        private TextBox txt_passw;
        private TextBox txt_subject;
        private RichTextBox richTextBox_body;
    }
}