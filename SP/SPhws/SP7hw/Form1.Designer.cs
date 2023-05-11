namespace SP7hw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tsButtonSelectFiles = new System.Windows.Forms.ToolStripButton();
            this.tsButtonEncrypt = new System.Windows.Forms.ToolStripButton();
            this.tsButtonDecrypt = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Originals:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsButtonSelectFiles,
            this.tsButtonEncrypt,
            this.tsButtonDecrypt});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(434, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 23);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 101);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 23);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 130);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 23);
            this.textBox4.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Encryptings:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(218, 43);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(200, 23);
            this.textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(218, 72);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(200, 23);
            this.textBox6.TabIndex = 8;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(218, 101);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(200, 23);
            this.textBox7.TabIndex = 9;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(218, 130);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(200, 23);
            this.textBox8.TabIndex = 10;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tsButtonSelectFiles
            // 
            this.tsButtonSelectFiles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsButtonSelectFiles.Image = ((System.Drawing.Image)(resources.GetObject("tsButtonSelectFiles.Image")));
            this.tsButtonSelectFiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonSelectFiles.Name = "tsButtonSelectFiles";
            this.tsButtonSelectFiles.Size = new System.Drawing.Size(68, 22);
            this.tsButtonSelectFiles.Text = "Select Files";
            this.tsButtonSelectFiles.Click += new System.EventHandler(this.tsButtonSelectFiles_Click);
            // 
            // tsButtonEncrypt
            // 
            this.tsButtonEncrypt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsButtonEncrypt.Image = ((System.Drawing.Image)(resources.GetObject("tsButtonEncrypt.Image")));
            this.tsButtonEncrypt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonEncrypt.Name = "tsButtonEncrypt";
            this.tsButtonEncrypt.Size = new System.Drawing.Size(51, 22);
            this.tsButtonEncrypt.Text = "Encrypt";
            this.tsButtonEncrypt.Click += new System.EventHandler(this.tsButtonEncrypt_Click);
            // 
            // tsButtonDecrypt
            // 
            this.tsButtonDecrypt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsButtonDecrypt.Image = ((System.Drawing.Image)(resources.GetObject("tsButtonDecrypt.Image")));
            this.tsButtonDecrypt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButtonDecrypt.Name = "tsButtonDecrypt";
            this.tsButtonDecrypt.Size = new System.Drawing.Size(52, 22);
            this.tsButtonDecrypt.Text = "Decrypt";
            this.tsButtonDecrypt.Click += new System.EventHandler(this.tsButtonDecrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 171);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ToolStrip toolStrip1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label2;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private OpenFileDialog openFileDialog1;
        private ToolStripButton tsButtonSelectFiles;
        private ToolStripButton tsButtonEncrypt;
        private ToolStripButton tsButtonDecrypt;
    }
}