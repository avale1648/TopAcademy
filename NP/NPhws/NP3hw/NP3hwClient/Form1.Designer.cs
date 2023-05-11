namespace NP3hwClient
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSelectFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSendFile = new System.Windows.Forms.ToolStripButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSelectFile,
            this.toolStripButtonSendFile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonSelectFile
            // 
            this.toolStripButtonSelectFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSelectFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSelectFile.Image")));
            this.toolStripButtonSelectFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSelectFile.Name = "toolStripButtonSelectFile";
            this.toolStripButtonSelectFile.Size = new System.Drawing.Size(99, 22);
            this.toolStripButtonSelectFile.Text = "Выбрать файл...";
            this.toolStripButtonSelectFile.Click += new System.EventHandler(this.toolStripButtonSelectFile_Click);
            // 
            // toolStripButtonSendFile
            // 
            this.toolStripButtonSendFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSendFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSendFile.Image")));
            this.toolStripButtonSendFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSendFile.Name = "toolStripButtonSendFile";
            this.toolStripButtonSendFile.Size = new System.Drawing.Size(69, 22);
            this.toolStripButtonSendFile.Text = "Отправить";
            this.toolStripButtonSendFile.Click += new System.EventHandler(this.toolStripButtonSendFile_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 28);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(150, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonSelectFile;
        private ToolStripButton toolStripButtonSendFile;
        private ProgressBar progressBar1;
    }
}