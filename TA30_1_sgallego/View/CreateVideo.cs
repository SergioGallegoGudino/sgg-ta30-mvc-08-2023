using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TA30_1_sgallego.Model;

namespace TA30_1_sgallego.View
{
    public partial class CreateVideo : Form
    {
        int idCont = 0;

        public CreateVideo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateVideo_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<Cliente> listaClientes = Cliente.GetClientes();

                String titulo = Titulo.Text;
                String director = Director.Text;
                int indice = listaClientes.FindIndex(cliente => cliente.Id == int.Parse(ID.Text));
                Cliente clienteVideo = listaClientes[indice];
                Video nuevoVideo = new Video
                {
                    Id = idCont,
                    Titulo = titulo,
                    Director = director,
                    Cliente = clienteVideo,
                };

                Video.AddVideo(nuevoVideo);
                idCont++;
                Titulo.Clear();
                Director.Clear();

            }
            catch (ArgumentOutOfRangeException)
            {

            }

            


        }
    }
}
