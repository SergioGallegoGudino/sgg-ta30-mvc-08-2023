using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TA30_2_sgallego.Model;

namespace TA30_2_sgallego.View
{
    public partial class UpdateCientifico : Form
    {
        public UpdateCientifico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                String dni = Dni.Text;
                String nombreApel = Nombre.Text;

                Cientificos cientificoEdit = new Cientificos
                {
                    Dni = dni,
                    NomApels = nombreApel,
                };

                Cientificos.UpdateCientificos(cientificoEdit);

                Dni.Clear();
                Nombre.Clear();

            }
            catch (Exception)
            {

            }
        }
    }
}
