namespace Lab3
{
    partial class Bai2
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
            _listen = new Button();
            _text = new ListView();
            SuspendLayout();
            // 
            // _listen
            // 
            _listen.Location = new Point(16, 502);
            _listen.Margin = new Padding(4, 5, 4, 5);
            _listen.Name = "_listen";
            _listen.Size = new Size(100, 35);
            _listen.TabIndex = 0;
            _listen.Text = "Listen";
            _listen.UseVisualStyleBackColor = true;
            _listen.Click += _listen_Click;
            // 
            // _text
            // 
            _text.Location = new Point(20, 23);
            _text.Margin = new Padding(4, 5, 4, 5);
            _text.Name = "_text";
            _text.Size = new Size(399, 459);
            _text.TabIndex = 2;
            _text.UseCompatibleStateImageBehavior = false;
            _text.View = View.List;
            _text.SelectedIndexChanged += _text_SelectedIndexChanged;
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 555);
            Controls.Add(_text);
            Controls.Add(_listen);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Bai2";
            Text = "Bai2";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button _listen;
        private ListView _text;
    }
}

