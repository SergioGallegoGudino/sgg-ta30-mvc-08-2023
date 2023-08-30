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
    public partial class CreateProyecto : Form
    {
        public CreateProyecto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String id = Id.Text;
            String nombre = Nombre.Text;
            int horas = int.Parse(Horas.Text);

            Proyecto proyecto = new Proyecto
            {
                Id = id,
                Nombre = nombre,
                Horas = horas
            };

            Proyecto.AddProyecto(proyecto);

            Id.Clear();
            Nombre.Clear();

        }
    }
}
