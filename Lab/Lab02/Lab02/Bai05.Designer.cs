namespace Bai05;

partial class Bai5
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
        button1 = new Button();
        label1 = new Label();
        textBox1 = new TextBox();
        listView1 = new ListView();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(26, 28);
        button1.Name = "button1";
        button1.Size = new Size(128, 29);
        button1.TabIndex = 0;
        button1.Text = "Select Directory";
        button1.UseVisualStyleBackColor = true;
        button1.Click += btnRead_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(202, 32);
        label1.Name = "label1";
        label1.Size = new Size(39, 20);
        label1.TabIndex = 1;
        label1.Text = "path";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(255, 24);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(391, 34);
        textBox1.TabIndex = 2;
        // 
        // listView1
        // 
        listView1.Location = new Point(26, 82);
        listView1.Name = "listView1";
        listView1.Size = new Size(620, 356);
        listView1.TabIndex = 3;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
        // 
        // Bai5
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(listView1);
        Controls.Add(textBox1);
        Controls.Add(label1);
        Controls.Add(button1);
        Name = "Bai5";
        Text = "Bai5";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private Label label1;
    private TextBox textBox1;
    private ListView listView1;
}
