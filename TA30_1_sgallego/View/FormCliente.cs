using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace TA30_1_sgallego.View
{
    public partial class FormCliente : Form
    {
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button4;

        public FormCliente()
        {
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Create delete = new Create();
            delete.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Read read = new Read();
            read.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            update.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.Show();
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 67);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ver cliente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(258, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 67);
            this.button3.TabIndex = 2;
            this.button3.Text = "Editar cliente";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(387, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 67);
            this.button4.TabIndex = 3;
            this.button4.Text = "Borrar cliente";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(27, 125);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 67);
            this.button5.TabIndex = 4;
            this.button5.Text = "Crear video";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(138, 125);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 67);
            this.button6.TabIndex = 5;
            this.button6.Text = "Ver video";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(258, 125);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 67);
            this.button7.TabIndex = 6;
            this.button7.Text = "Editar video";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(387, 125);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 67);
            this.button8.TabIndex = 7;
            this.button8.Text = "Borrar video";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // FormCliente
            // 
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormCliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.ResumeLayout(false);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            CreateVideo crear = new CreateVideo();
            crear.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReadVideos readVideos = new ReadVideos();
            readVideos.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UpdateVideos updateVideos = new UpdateVideos();
            updateVideos.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DeleteVideos deleteVideos = new DeleteVideos();
            deleteVideos.Show();
        }
    }
}
