namespace TA30_mvc_sgallego.View
{
    partial class Create
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
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Apellidos = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.DNI = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DNI)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(16, 45);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 22);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre";
            this.Nombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Apellidos
            // 
            this.Apellidos.Location = new System.Drawing.Point(16, 88);
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Size = new System.Drawing.Size(100, 22);
            this.Apellidos.TabIndex = 2;
            this.Apellidos.Text = "Apellidos";
            this.Apellidos.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Direccion
            // 
            this.Direccion.Location = new System.Drawing.Point(16, 129);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(100, 22);
            this.Direccion.TabIndex = 3;
            this.Direccion.Text = "Direccion";
            this.Direccion.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(16, 209);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(200, 22);
            this.Fecha.TabIndex = 5;
            this.Fecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // DNI
            // 
            this.DNI.Location = new System.Drawing.Point(16, 171);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(120, 22);
            this.DNI.TabIndex = 6;
            this.DNI.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "DNI";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DNI);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.Apellidos);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label1);
            this.Name = "Create";
            this.Text = "Create";
            this.Load += new System.EventHandler(this.Create_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DNI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Apellidos;
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.NumericUpDown DNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}