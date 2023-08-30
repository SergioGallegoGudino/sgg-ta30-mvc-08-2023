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
    public partial class Read : Form
    {
        public Read()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Read_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void MostrarClientes()
        {
            List<Cliente> listaClientes = Cliente.GetClientes();

            lista.Items.Clear();

            foreach (Cliente cliente in listaClientes)
            {
                lista.Items.Add($"ID: {cliente.Id}, Nombre: {cliente.Nombre}, Apellidos: {cliente.Apellido}, Direccion: {cliente.Direccion}, DNI: {cliente.Dni}, Fecha de nacimiento: {cliente.Fecha}");
            }
        }
    }
}
