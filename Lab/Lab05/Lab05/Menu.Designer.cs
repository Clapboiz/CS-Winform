namespace Lab05
{
    partial class Menu
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
            this.btn_Bai01 = new System.Windows.Forms.Button();
            this.btn_Bai02 = new System.Windows.Forms.Button();
            this.btn_Bai03 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Bai01
            // 
            this.btn_Bai01.Location = new System.Drawing.Point(227, 210);
            this.btn_Bai01.Name = "btn_Bai01";
            this.btn_Bai01.Size = new System.Drawing.Size(94, 29);
            this.btn_Bai01.TabIndex = 0;
            this.btn_Bai01.Text = "Bài 1";
            this.btn_Bai01.UseVisualStyleBackColor = true;
            this.btn_Bai01.Click += new System.EventHandler(this.btn_Bai01_Click);
            // 
            // btn_Bai02
            // 
            this.btn_Bai02.Location = new System.Drawing.Point(342, 210);
            this.btn_Bai02.Name = "btn_Bai02";
            this.btn_Bai02.Size = new System.Drawing.Size(94, 29);
            this.btn_Bai02.TabIndex = 1;
            this.btn_Bai02.Text = "Bài 2";
            this.btn_Bai02.UseVisualStyleBackColor = true;
            this.btn_Bai02.Click += new System.EventHandler(this.btn_Bai02_Click);
            // 
            // btn_Bai03
            // 
            this.btn_Bai03.Location = new System.Drawing.Point(454, 210);
            this.btn_Bai03.Name = "btn_Bai03";
            this.btn_Bai03.Size = new System.Drawing.Size(94, 29);
            this.btn_Bai03.TabIndex = 2;
            this.btn_Bai03.Text = "Bài 3";
            this.btn_Bai03.UseVisualStyleBackColor = true;
            this.btn_Bai03.Click += new System.EventHandler(this.btn_Bai03_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Bai03);
            this.Controls.Add(this.btn_Bai02);
            this.Controls.Add(this.btn_Bai01);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Bai01;
        private Button btn_Bai02;
        private Button btn_Bai03;
    }
}