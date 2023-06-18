namespace Lab04
{
    partial class Bai02
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
            this._url = new System.Windows.Forms.TextBox();
            this._post = new System.Windows.Forms.Button();
            this._response = new System.Windows.Forms.RichTextBox();
            this._content = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _url
            // 
            this._url.Location = new System.Drawing.Point(12, 12);
            this._url.Name = "_url";
            this._url.Size = new System.Drawing.Size(406, 20);
            this._url.TabIndex = 0;
            // 
            // _post
            // 
            this._post.Location = new System.Drawing.Point(424, 10);
            this._post.Name = "_post";
            this._post.Size = new System.Drawing.Size(75, 23);
            this._post.TabIndex = 1;
            this._post.Text = "POST";
            this._post.UseVisualStyleBackColor = true;
            this._post.Click += new System.EventHandler(this._post_Click);
            // 
            // _response
            // 
            this._response.Location = new System.Drawing.Point(12, 64);
            this._response.Name = "_response";
            this._response.Size = new System.Drawing.Size(406, 257);
            this._response.TabIndex = 3;
            this._response.Text = "";
            // 
            // _content
            // 
            this._content.Location = new System.Drawing.Point(12, 38);
            this._content.Name = "_content";
            this._content.Size = new System.Drawing.Size(406, 20);
            this._content.TabIndex = 4;
            // 
            // Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 355);
            this.Controls.Add(this._content);
            this.Controls.Add(this._response);
            this.Controls.Add(this._post);
            this.Controls.Add(this._url);
            this.Name = "Bai02";
            this.Text = "Bai02";
            this.Load += new System.EventHandler(this.Bai02_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _url;
        private System.Windows.Forms.Button _post;
        private System.Windows.Forms.RichTextBox _response;
        private System.Windows.Forms.TextBox _content;
    }
}

