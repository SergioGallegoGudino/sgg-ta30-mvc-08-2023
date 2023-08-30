using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TA30_2_sgallego.Model;

namespace TA30_2_sgallego.View
{
    public partial class ReadCientifico : Form
    {
        public ReadCientifico()
        {
            InitializeComponent();
            mostrarCientificos();
        }

        public  void mostrarCientificos()
        {
            List<Cientificos> listaCientificos = Cientificos.GetCientificos();

            lista.Items.Clear();

            foreach (Cientificos video in listaCientificos)
            {
                this.lista.Items.Add($"DNI: {video.Dni} - Nombre Completo: {video.NomApels}");
            }
        }
    }
}
