﻿namespace TA30_2_sgallego.View
{
    partial class AsignarProyecto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dni = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI cientifico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID proyecto";
            // 
            // Dni
            // 
            this.Dni.Location = new System.Drawing.Point(31, 53);
            this.Dni.Name = "Dni";
            this.Dni.Size = new System.Drawing.Size(100, 22);
            this.Dni.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(242, 53);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(100, 22);
            this.Id.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Asignar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AsignarProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.Dni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AsignarProyecto";
            this.Text = "AsignarProyecto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Dni;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Button button1;
    }
}