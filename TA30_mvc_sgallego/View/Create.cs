using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TA30_mvc_sgallego.Model;

namespace TA30_mvc_sgallego.View
{
    public partial class Create : Form
    {
        int idCont = 0;

        public Create()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre = Nombre.Text;
            String apellidos = Apellidos.Text;
            String direccion = Direccion.Text;
            int dni = int.Parse(DNI.Text);
            DateTime fecha = DateTime.Parse(Fecha.Text);

            Cliente nuevoCliente = new Cliente
            {
                Id = idCont,
                Nombre = nombre,
                Apellido = apellidos,
                Direccion = direccion,
                Dni = dni,
                Fecha = fecha
            };
            
            Cliente.AddCliente(nuevoCliente);
            idCont++;
            Nombre.Clear();
            Apellidos.Clear();
            Direccion.Clear();

            

        }

        private void Create_Load(object sender, EventArgs e)
        {

        }
    }
}
