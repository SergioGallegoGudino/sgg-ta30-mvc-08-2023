namespace TA30_1_sgallego.View
{
    partial class UpdateVideos
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Actualizar = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.NumericUpDown();
            this.Director = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.TextBox();
            this.IdVideos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ID)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Director";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Titulo";
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(28, 218);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(75, 23);
            this.Actualizar.TabIndex = 10;
            this.Actualizar.Text = "Crear";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(28, 174);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(120, 22);
            this.ID.TabIndex = 9;
            // 
            // Director
            // 
            this.Director.Location = new System.Drawing.Point(28, 124);
            this.Director.Name = "Director";
            this.Director.Size = new System.Drawing.Size(100, 22);
            this.Director.TabIndex = 8;
            this.Director.Text = "Director";
            // 
            // Titulo
            // 
            this.Titulo.Location = new System.Drawing.Point(28, 79);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(100, 22);
            this.Titulo.TabIndex = 7;
            this.Titulo.Text = "Titulo";
            // 
            // IdVideos
            // 
            this.IdVideos.Location = new System.Drawing.Point(28, 34);
            this.IdVideos.Name = "IdVideos";
            this.IdVideos.Size = new System.Drawing.Size(100, 22);
            this.IdVideos.TabIndex = 14;
            this.IdVideos.Text = "ID video";
            this.IdVideos.TextChanged += new System.EventHandler(this.IdVideos_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Id";
            // 
            // UpdateVideos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IdVideos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Director);
            this.Controls.Add(this.Titulo);
            this.Name = "UpdateVideos";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.NumericUpDown ID;
        private System.Windows.Forms.TextBox Director;
        private System.Windows.Forms.TextBox Titulo;
        private System.Windows.Forms.TextBox IdVideos;
        private System.Windows.Forms.Label label4;
    }
}