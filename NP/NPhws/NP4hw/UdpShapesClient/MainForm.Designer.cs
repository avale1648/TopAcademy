﻿namespace UdpShapesClient {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.comboBoxChangeColour = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxChangeColour
            // 
            this.comboBoxChangeColour.FormattingEnabled = true;
            this.comboBoxChangeColour.Location = new System.Drawing.Point(12, 12);
            this.comboBoxChangeColour.Name = "comboBoxChangeColour";
            this.comboBoxChangeColour.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChangeColour.TabIndex = 0;
            this.comboBoxChangeColour.SelectedIndexChanged += new System.EventHandler(this.comboBoxChangeColour_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxChangeColour);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Shapes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChangeColour;
    }
}

