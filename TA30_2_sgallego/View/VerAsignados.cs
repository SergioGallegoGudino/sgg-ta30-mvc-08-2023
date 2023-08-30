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
    public partial class VerAsignados : Form
    {
        public VerAsignados()
        {
            InitializeComponent();
            MostrarAsignados();
        }

        public void MostrarAsignados()
        {
            List<Asignado> listaAsignados = Asignado.GetAsignados();

            lista.Items.Clear();

            foreach (Asignado asignado in listaAsignados)
            {
                this.lista.Items.Add($"DNI - Cientifico: {asignado.Dni} | ID - Proyecto: {asignado.Id}");
            }
        }
    }
}
