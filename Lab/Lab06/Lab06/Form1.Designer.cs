namespace Lab06
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
            components = new System.ComponentModel.Container();
            server = new Label();
            label1 = new Label();
            txt_server = new TextBox();
            txt_file = new TextBox();
            btn_open = new Button();
            btn_upload = new Button();
            btn_download = new Button();
            listView1 = new ListView();
            openFileDialog1 = new OpenFileDialog();
            a = new Label();
            b = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            saveFileDialog1 = new SaveFileDialog();
            btn_show = new Button();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // server
            // 
            server.AutoSize = true;
            server.Font = new Font("UTM Neo Sans Intel", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            server.Location = new Point(55, 40);
            server.Name = "server";
            server.Size = new Size(57, 24);
            server.TabIndex = 0;
            server.Text = "server";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UTM Neo Sans Intel", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 104);
            label1.Name = "label1";
            label1.Size = new Size(107, 24);
            label1.TabIndex = 1;
            label1.Text = "File to upload";
            // 
            // txt_server
            // 
            txt_server.Location = new Point(130, 41);
            txt_server.Name = "txt_server";
            txt_server.Size = new Size(170, 27);
            txt_server.TabIndex = 2;
            txt_server.Text = "ftp://127.0.0.1";
            // 
            // txt_file
            // 
            txt_file.Location = new Point(168, 104);
            txt_file.Name = "txt_file";
            txt_file.Size = new Size(263, 27);
            txt_file.TabIndex = 3;
            // 
            // btn_open
            // 
            btn_open.Font = new Font("UTM Neo Sans Intel", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_open.ImageAlign = ContentAlignment.TopCenter;
            btn_open.Location = new Point(437, 99);
            btn_open.Name = "btn_open";
            btn_open.Size = new Size(37, 35);
            btn_open.TabIndex = 4;
            btn_open.Text = "...";
            btn_open.UseVisualStyleBackColor = true;
            btn_open.Click += btn_open_Click;
            // 
            // btn_upload
            // 
            btn_upload.Font = new Font("UTM Neo Sans Intel", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_upload.ImageAlign = ContentAlignment.TopCenter;
            btn_upload.Location = new Point(476, 99);
            btn_upload.Name = "btn_upload";
            btn_upload.Size = new Size(97, 35);
            btn_upload.TabIndex = 5;
            btn_upload.Text = "Upload";
            btn_upload.UseVisualStyleBackColor = true;
            btn_upload.Click += btn_upload_Click;
            // 
            // btn_download
            // 
            btn_download.Font = new Font("UTM Neo Sans Intel", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_download.ImageAlign = ContentAlignment.TopCenter;
            btn_download.Location = new Point(579, 99);
            btn_download.Name = "btn_download";
            btn_download.Size = new Size(97, 35);
            btn_download.TabIndex = 6;
            btn_download.Text = "Download";
            btn_download.UseVisualStyleBackColor = true;
            btn_download.Click += btn_download_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(55, 169);
            listView1.Name = "listView1";
            listView1.Size = new Size(719, 246);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // a
            // 
            a.AutoSize = true;
            a.Font = new Font("UTM Neo Sans Intel", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            a.Location = new Point(320, 43);
            a.Name = "a";
            a.Size = new Size(83, 24);
            a.TabIndex = 8;
            a.Text = "Username";
            // 
            // b
            // 
            b.AutoSize = true;
            b.Font = new Font("UTM Neo Sans Intel", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            b.Location = new Point(564, 44);
            b.Name = "b";
            b.Size = new Size(81, 24);
            b.TabIndex = 9;
            b.Text = "Password";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(409, 44);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(149, 27);
            txt_username.TabIndex = 10;
            txt_username.Text = "user";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(651, 45);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(123, 27);
            txt_password.TabIndex = 11;
            txt_password.Text = "12345";
            // 
            // btn_show
            // 
            btn_show.Font = new Font("UTM Neo Sans Intel", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_show.ImageAlign = ContentAlignment.TopCenter;
            btn_show.Location = new Point(682, 99);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(92, 35);
            btn_show.TabIndex = 12;
            btn_show.Text = "Show";
            btn_show.UseVisualStyleBackColor = true;
            btn_show.Click += btn_show_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 450);
            Controls.Add(btn_show);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(b);
            Controls.Add(a);
            Controls.Add(listView1);
            Controls.Add(btn_download);
            Controls.Add(btn_upload);
            Controls.Add(btn_open);
            Controls.Add(txt_file);
            Controls.Add(txt_server);
            Controls.Add(label1);
            Controls.Add(server);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label server;
        private Label label1;
        private TextBox txt_server;
        private TextBox txt_file;
        private Button btn_open;
        private Button btn_upload;
        private Button btn_download;
        private ListView listView1;
        private OpenFileDialog openFileDialog1;
        private Label a;
        private Label b;
        private TextBox txt_username;
        private TextBox txt_password;
        private SaveFileDialog saveFileDialog1;
        private Button btn_show;
        private BindingSource bindingSource1;
    }
}