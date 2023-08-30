namespace TA30_mvc_sgallego.View
{
    partial class Update
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DNI = new System.Windows.Forms.NumericUpDown();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.Apellidos = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DNI)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "DNI";
            // 
            // DNI
            // 
            this.DNI.Location = new System.Drawing.Point(39, 216);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(120, 22);
            this.DNI.TabIndex = 15;
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(39, 254);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(200, 22);
            this.Fecha.TabIndex = 14;
            // 
            // Direccion
            // 
            this.Direccion.Location = new System.Drawing.Point(39, 174);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(100, 22);
            this.Direccion.TabIndex = 13;
            this.Direccion.Text = "Direccion";
            // 
            // Apellidos
            // 
            this.Apellidos.Location = new System.Drawing.Point(39, 133);
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Size = new System.Drawing.Size(100, 22);
            this.Apellidos.TabIndex = 12;
            this.Apellidos.Text = "Apellidos";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(39, 90);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 22);
            this.Nombre.TabIndex = 11;
            this.Nombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Editar cliente";
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(39, 52);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(100, 22);
            this.Id.TabIndex = 19;
            this.Id.Text = "Id";
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DNI);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.Apellidos);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label1);
            this.Name = "Update";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DNI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown DNI;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.TextBox Apellidos;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Id;
    }
}