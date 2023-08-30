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
    public partial class ReadVideos : Form
    {
        public ReadVideos()
        {
            InitializeComponent();
            MostrarVideos();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MostrarVideos()
        {
            List<Video> listaVideo = Video.GetVideos();

            this.listaVideos.Items.Clear();

            foreach (Video video in listaVideo)
            {
                this.listaVideos.Items.Add($"ID: {video.Id}, Titulo: {video.Titulo}, Director: {video.Director}, Cliente: ID - {video.Cliente.Id} | Nombre - {video.Cliente.Nombre}");
            }
        }

        private void lista_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ReadVideos_Load(object sender, EventArgs e)
        {
            MostrarVideos();
        }
    }
}
