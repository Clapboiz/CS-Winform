namespace Sakk_Alkalmazás_2._0
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
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_show_pasw = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_pasw = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_confirm_pasw = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login.Font = new System.Drawing.Font("UTM Avo", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_login.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_login.Location = new System.Drawing.Point(556, 497);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(344, 45);
            this.btn_login.TabIndex = 16;
            this.btn_login.Text = "BACK TO LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_back_login_Click);
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("UTM Avo", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(556, 409);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(344, 45);
            this.btn_register.TabIndex = 15;
            this.btn_register.Text = "REGISTER";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_Click_Register);
            // 
            // btn_show_pasw
            // 
            this.btn_show_pasw.AutoSize = true;
            this.btn_show_pasw.BackColor = System.Drawing.Color.White;
            this.btn_show_pasw.Font = new System.Drawing.Font("UTM Neo Sans Intel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_pasw.Location = new System.Drawing.Point(817, 372);
            this.btn_show_pasw.Name = "btn_show_pasw";
            this.btn_show_pasw.Size = new System.Drawing.Size(118, 22);
            this.btn_show_pasw.TabIndex = 14;
            this.btn_show_pasw.Text = "Show password";
            this.btn_show_pasw.UseVisualStyleBackColor = false;
            this.btn_show_pasw.Click += new System.EventHandler(this.btn_show_pasw_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.txt_pasw);
            this.panel2.Location = new System.Drawing.Point(517, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 38);
            this.panel2.TabIndex = 13;
            // 
            // txt_pasw
            // 
            this.txt_pasw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pasw.Font = new System.Drawing.Font("UTM Neo Sans Intel", 10.2F);
            this.txt_pasw.Location = new System.Drawing.Point(0, -1);
            this.txt_pasw.Multiline = true;
            this.txt_pasw.Name = "txt_pasw";
            this.txt_pasw.PasswordChar = '*';
            this.txt_pasw.Size = new System.Drawing.Size(424, 35);
            this.txt_pasw.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Location = new System.Drawing.Point(517, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 38);
            this.panel1.TabIndex = 12;
            // 
            // txt_username
            // 
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Font = new System.Drawing.Font("UTM Neo Sans Intel", 10.2F);
            this.txt_username.Location = new System.Drawing.Point(0, -1);
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(424, 35);
            this.txt_username.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("UTM Neo Sans Intel", 12F);
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(512, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("UTM Neo Sans Intel", 12F);
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(512, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("UTM Neo Sans Intel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(619, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 56);
            this.label1.TabIndex = 9;
            this.label1.Text = "Get Started";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("UTM Neo Sans Intel", 12F);
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(624, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 27);
            this.label4.TabIndex = 17;
            this.label4.Text = "Already Have An Account";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.txt_confirm_pasw);
            this.panel3.Location = new System.Drawing.Point(517, 319);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(424, 38);
            this.panel3.TabIndex = 15;
            // 
            // txt_confirm_pasw
            // 
            this.txt_confirm_pasw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_confirm_pasw.Font = new System.Drawing.Font("UTM Neo Sans Intel", 10.2F);
            this.txt_confirm_pasw.Location = new System.Drawing.Point(0, -1);
            this.txt_confirm_pasw.Multiline = true;
            this.txt_confirm_pasw.Name = "txt_confirm_pasw";
            this.txt_confirm_pasw.PasswordChar = '*';
            this.txt_confirm_pasw.Size = new System.Drawing.Size(424, 35);
            this.txt_confirm_pasw.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("UTM Neo Sans Intel", 12F);
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(512, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 27);
            this.label5.TabIndex = 14;
            this.label5.Text = "Confirm Password";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_show_pasw);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.CheckBox btn_show_pasw;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_pasw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_confirm_pasw;
        private System.Windows.Forms.Label label5;
    }
}