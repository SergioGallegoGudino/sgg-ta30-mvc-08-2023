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
    public partial class AsignarProyecto : Form
    {
        public AsignarProyecto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String dni = Dni.Text;
            String id = Id.Text;

            Asignado.AsignarProyecto(dni, id);
        }
    }
}
