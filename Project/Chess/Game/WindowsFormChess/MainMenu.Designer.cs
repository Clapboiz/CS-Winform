
namespace Sakk_Alkalmazás_2._0
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.Start_btn = new System.Windows.Forms.Button();
            this.Connection_btn = new System.Windows.Forms.Button();
            this.AI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start_btn
            // 
            this.Start_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Start_btn.BackColor = System.Drawing.Color.White;
            this.Start_btn.FlatAppearance.BorderSize = 0;
            this.Start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Start_btn.Location = new System.Drawing.Point(511, 354);
            this.Start_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(167, 53);
            this.Start_btn.TabIndex = 0;
            this.Start_btn.Text = "Single Game";
            this.Start_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Start_btn.UseVisualStyleBackColor = false;
            this.Start_btn.UseWaitCursor = true;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // Connection_btn
            // 
            this.Connection_btn.BackColor = System.Drawing.Color.White;
            this.Connection_btn.FlatAppearance.BorderSize = 0;
            this.Connection_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connection_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Connection_btn.Location = new System.Drawing.Point(511, 420);
            this.Connection_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Connection_btn.Name = "Connection_btn";
            this.Connection_btn.Size = new System.Drawing.Size(167, 51);
            this.Connection_btn.TabIndex = 0;
            this.Connection_btn.Text = "Lan Game";
            this.Connection_btn.UseVisualStyleBackColor = false;
            this.Connection_btn.Click += new System.EventHandler(this.Connection_btn_Click);
            // 
            // AI
            // 
            this.AI.BackColor = System.Drawing.Color.White;
            this.AI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.AI.Location = new System.Drawing.Point(511, 481);
            this.AI.Name = "AI";
            this.AI.Size = new System.Drawing.Size(167, 39);
            this.AI.TabIndex = 2;
            this.AI.Text = "AI Game";
            this.AI.UseVisualStyleBackColor = false;
            this.AI.Click += new System.EventHandler(this.AI_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 853);
            this.Controls.Add(this.AI);
            this.Controls.Add(this.Connection_btn);
            this.Controls.Add(this.Start_btn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.Button Connection_btn;
        private System.Windows.Forms.Button AI;
    }
}