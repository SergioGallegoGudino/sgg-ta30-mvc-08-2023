using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA30_mvc_sgallego.View
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Crear
        {
            Create create = new Create();
            create.Show();

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

        private void button4_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.Show();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            
        }
    }
}
