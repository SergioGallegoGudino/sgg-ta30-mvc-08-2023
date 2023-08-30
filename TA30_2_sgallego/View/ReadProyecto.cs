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
    public partial class ReadProyecto : Form
    {
        public ReadProyecto()
        {
            InitializeComponent();
            mostrarProyectos();
        }

        public void mostrarProyectos()
        {
            List<Proyecto> listaProyectos = Proyecto.GetProyectos();

            lista.Items.Clear();

            foreach (Proyecto proyecto in listaProyectos)
            {
                this.lista.Items.Add($"ID: {proyecto.Id} - Nombre : {proyecto.Nombre} - Horas: {proyecto.Horas}");
            }
        }
    }
}
