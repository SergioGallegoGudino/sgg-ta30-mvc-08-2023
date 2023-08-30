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
using TA30_2_sgallego.Model;

namespace TA30_2_sgallego.View
{
    public partial class UpdateProyecto : Form
    {
        public UpdateProyecto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                String id = Id.Text;
                String nombre = Nombre.Text;
                int horas = int.Parse(Horas.Text);

                Proyecto proyectoEdit = new Proyecto
                {
                    Id = id,
                    Nombre = nombre,
                    Horas = horas
                };

                Proyecto.UpdateProyecto(proyectoEdit);

                Id.Clear();
                Nombre.Clear();

            }
            catch (Exception)
            {
                
            }
        }
    }
}
