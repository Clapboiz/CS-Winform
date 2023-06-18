namespace Lab3
{
    partial class Form1
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
            this._listen = new System.Windows.Forms.Button();
            this._text = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // _listen
            // 
            this._listen.Location = new System.Drawing.Point(12, 326);
            this._listen.Name = "_listen";
            this._listen.Size = new System.Drawing.Size(75, 23);
            this._listen.TabIndex = 0;
            this._listen.Text = "Listen";
            this._listen.UseVisualStyleBackColor = true;
            this._listen.Click += new System.EventHandler(this._listen_Click);
            // 
            // _text
            // 
            this._text.HideSelection = false;
            this._text.Location = new System.Drawing.Point(15, 15);
            this._text.Name = "_text";
            this._text.Size = new System.Drawing.Size(300, 300);
            this._text.TabIndex = 2;
            this._text.UseCompatibleStateImageBehavior = false;
            this._text.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this._text);
            this.Controls.Add(this._listen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _listen;
        private System.Windows.Forms.ListView _text;
    }
}

