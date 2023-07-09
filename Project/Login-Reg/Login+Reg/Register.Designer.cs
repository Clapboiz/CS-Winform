namespace Login_Reg
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.btn_back_login = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_pasw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_confirm_pasw = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_show_pasw = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_back_login
            // 
            this.btn_back_login.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_back_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_back_login.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_back_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back_login.Font = new System.Drawing.Font("UTM Avo", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_back_login.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_back_login.Location = new System.Drawing.Point(562, 493);
            this.btn_back_login.Name = "btn_back_login";
            this.btn_back_login.Size = new System.Drawing.Size(303, 45);
            this.btn_back_login.TabIndex = 13;
            this.btn_back_login.Text = "Back To Login";
            this.btn_back_login.UseVisualStyleBackColor = false;
            this.btn_back_login.Click += new System.EventHandler(this.btn_back_login_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("UTM Avo", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(562, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(303, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_Click_Register);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("UTM Neo Sans Intel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(506, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.txt_pasw);
            this.panel2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Location = new System.Drawing.Point(506, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 45);
            this.panel2.TabIndex = 10;
            // 
            // txt_pasw
            // 
            this.txt_pasw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pasw.Location = new System.Drawing.Point(0, 0);
            this.txt_pasw.Multiline = true;
            this.txt_pasw.Name = "txt_pasw";
            this.txt_pasw.PasswordChar = '*';
            this.txt_pasw.Size = new System.Drawing.Size(405, 41);
            this.txt_pasw.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("UTM Neo Sans Intel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(506, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "User Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Location = new System.Drawing.Point(506, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 45);
            this.panel1.TabIndex = 8;
            // 
            // txt_username
            // 
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Location = new System.Drawing.Point(0, 0);
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(405, 41);
            this.txt_username.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("UTM Neo Sans Intel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(634, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 56);
            this.label1.TabIndex = 7;
            this.label1.Text = "Get Started";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("UTM Neo Sans Intel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(506, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 27);
            this.label4.TabIndex = 15;
            this.label4.Text = "Confirm Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.txt_confirm_pasw);
            this.panel3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Location = new System.Drawing.Point(506, 315);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 45);
            this.panel3.TabIndex = 14;
            // 
            // txt_confirm_pasw
            // 
            this.txt_confirm_pasw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_confirm_pasw.Location = new System.Drawing.Point(0, 0);
            this.txt_confirm_pasw.Multiline = true;
            this.txt_confirm_pasw.Name = "txt_confirm_pasw";
            this.txt_confirm_pasw.PasswordChar = '*';
            this.txt_confirm_pasw.Size = new System.Drawing.Size(405, 41);
            this.txt_confirm_pasw.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("UTM Neo Sans Intel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(607, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Already Have An Account";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_show_pasw
            // 
            this.btn_show_pasw.AutoSize = true;
            this.btn_show_pasw.BackColor = System.Drawing.SystemColors.Window;
            this.btn_show_pasw.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_show_pasw.Location = new System.Drawing.Point(779, 370);
            this.btn_show_pasw.Name = "btn_show_pasw";
            this.btn_show_pasw.Size = new System.Drawing.Size(132, 24);
            this.btn_show_pasw.TabIndex = 17;
            this.btn_show_pasw.Text = "Show Password";
            this.btn_show_pasw.UseVisualStyleBackColor = false;
            this.btn_show_pasw.Click += new System.EventHandler(this.btn_show_pasw_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.btn_show_pasw);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_back_login);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Register";
            this.Text = "Register";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_back_login;
        private Button button1;
        private Label label3;
        private Panel panel2;
        private TextBox txt_pasw;
        private Label label2;
        private Panel panel1;
        private TextBox txt_username;
        private Label label1;
        private Label label4;
        private Panel panel3;
        private TextBox txt_confirm_pasw;
        private Label label5;
        private CheckBox btn_show_pasw;
    }
}