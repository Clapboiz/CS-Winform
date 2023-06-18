namespace Lab04
{
    partial class Bai03
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.box_url = new System.Windows.Forms.TextBox();
            this.box_save = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(129, 155);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(543, 226);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Download";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // box_url
            // 
            this.box_url.Location = new System.Drawing.Point(129, 51);
            this.box_url.Multiline = true;
            this.box_url.Name = "box_url";
            this.box_url.Size = new System.Drawing.Size(431, 37);
            this.box_url.TabIndex = 3;
            // 
            // box_save
            // 
            this.box_save.Location = new System.Drawing.Point(129, 102);
            this.box_save.Multiline = true;
            this.box_save.Name = "box_save";
            this.box_save.Size = new System.Drawing.Size(543, 37);
            this.box_save.TabIndex = 6;
            this.box_save.Text = "D:\\File code\\c#\\THUC_HANH\\Lab04\\uit.html";
            // 
            // Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.box_save);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.box_url);
            this.Name = "Bai03";
            this.Text = "Bai03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button1;
        private TextBox box_url;
        private TextBox box_save;
    }
}