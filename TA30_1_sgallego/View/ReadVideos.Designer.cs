﻿namespace TA30_1_sgallego.View
{
    partial class ReadVideos
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
            this.listaVideos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listaVideos
            // 
            this.listaVideos.FormattingEnabled = true;
            this.listaVideos.ItemHeight = 16;
            this.listaVideos.Location = new System.Drawing.Point(21, 12);
            this.listaVideos.Name = "listaVideos";
            this.listaVideos.Size = new System.Drawing.Size(558, 324);
            this.listaVideos.TabIndex = 0;
            // 
            // ReadVideos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listaVideos);
            this.Name = "ReadVideos";
            this.Text = "ReadVideos";
            this.Load += new System.EventHandler(this.ReadVideos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaVideos;
    }
}