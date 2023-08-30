using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TA30_1_sgallego.Model;

namespace TA30_1_sgallego.View
{
    public partial class UpdateVideos : Form
    {
        public UpdateVideos()
        {
            InitializeComponent();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int idCliente = int.Parse(ID.Text);
                String titulo = Titulo.Text;
                String director = Director.Text;

                List<Cliente> listaClientes = Cliente.GetClientes();
                int idVideo = int.Parse(IdVideos.Text);
                int indice = listaClientes.FindIndex(cliente => cliente.Id == int.Parse(ID.Text));
                Cliente clienteVideo = listaClientes[indice];
                Video videoEdit = new Video
                {
                    Id = idVideo,
                    Titulo = titulo,
                    Director = director,
                    Cliente = clienteVideo,
                };

                Video.EditVideo(videoEdit);
            }
            catch (Exception)
            {

            }
        }

        private void IdVideos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
