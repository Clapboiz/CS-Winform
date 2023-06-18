namespace Lab04
{
    partial class Bai04
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.WebBrowser webBrowser1;
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
        private void InitializeComponent1()
        {
            // Các đoạn mã khởi tạo khác cho biểu mẫu

            // Tạo điều khiển WebBrowser
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            // Thiết lập các thuộc tính cho điều khiển WebBrowser
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(600, 500);
            this.webBrowser1.TabIndex = 0;
            // Thêm điều khiển WebBrowser vào bộ sưu tập điều khiển của biểu mẫu
            this.Controls.Add(this.webBrowser1);

            // Các đoạn mã khởi tạo khác cho biểu mẫu
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._url = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.forward = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.dow = new System.Windows.Forms.Button();
            this.viewsource = new System.Windows.Forms.Button();
            this._go = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _url
            // 
            this._url.Location = new System.Drawing.Point(319, 27);
            this._url.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._url.Name = "_url";
            this._url.Size = new System.Drawing.Size(299, 27);
            this._url.TabIndex = 0;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(16, 25);
            this.back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(49, 35);
            this.back.TabIndex = 1;
            this.back.Text = "<";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // forward
            // 
            this.forward.Location = new System.Drawing.Point(73, 25);
            this.forward.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(49, 35);
            this.forward.TabIndex = 2;
            this.forward.Text = ">";
            this.forward.UseVisualStyleBackColor = true;
            this.forward.Click += new System.EventHandler(this.forward_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(205, 24);
            this.refresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(49, 35);
            this.refresh.TabIndex = 3;
            this.refresh.Text = "F5";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // dow
            // 
            this.dow.Location = new System.Drawing.Point(627, 27);
            this.dow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dow.Name = "dow";
            this.dow.Size = new System.Drawing.Size(104, 35);
            this.dow.TabIndex = 4;
            this.dow.Text = "DownLoad";
            this.dow.UseVisualStyleBackColor = true;
            this.dow.Click += new System.EventHandler(this.dow_Click);
            // 
            // viewsource
            // 
            this.viewsource.Location = new System.Drawing.Point(739, 27);
            this.viewsource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewsource.Name = "viewsource";
            this.viewsource.Size = new System.Drawing.Size(104, 35);
            this.viewsource.TabIndex = 5;
            this.viewsource.Text = "View";
            this.viewsource.UseVisualStyleBackColor = true;
            this.viewsource.Click += new System.EventHandler(this.viewsource_Click);
            // 
            // _go
            // 
            this._go.Location = new System.Drawing.Point(262, 24);
            this._go.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._go.Name = "_go";
            this._go.Size = new System.Drawing.Size(49, 35);
            this._go.TabIndex = 6;
            this._go.Text = "Go";
            this._go.UseVisualStyleBackColor = true;
            this._go.Click += new System.EventHandler(this._go_Click);
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(127, 25);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(71, 35);
            this.btn_home.TabIndex = 7;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 863);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this._go);
            this.Controls.Add(this.viewsource);
            this.Controls.Add(this.dow);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.forward);
            this.Controls.Add(this.back);
            this.Controls.Add(this._url);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Bai04";
            this.Text = "Bai04";
            this.Load += new System.EventHandler(this.Bai04_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _url;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button forward;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button dow;
        private System.Windows.Forms.Button viewsource;
        private System.Windows.Forms.Button _go;
        private Button btn_home;
    }
}