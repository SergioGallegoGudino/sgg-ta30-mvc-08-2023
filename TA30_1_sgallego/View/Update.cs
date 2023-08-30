using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TA30_1_sgallego.Model;

namespace TA30_1_sgallego.View
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Id.Text);
            String nombre = Nombre.Text;
            String apellidos = Apellidos.Text;
            String direccion = Direccion.Text;
            int dni = int.Parse(DNI.Text);
            DateTime fecha = DateTime.Parse(Fecha.Text);

            Cliente clienteEdit = new Cliente
            {
                Id = id,
                Nombre = nombre,
                Apellido = apellidos,
                Direccion = direccion,
                Dni = dni,
                Fecha = fecha
            };

            Cliente.EditCliente(clienteEdit);
        }

        private void Id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
