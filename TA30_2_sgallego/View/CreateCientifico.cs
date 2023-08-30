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
    public partial class CreateCientifico : Form
    {
        public CreateCientifico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String dni = Dni.Text;
            String nombreApel = Nombre.Text;


            Cientificos c = new Cientificos
            {
                Dni = dni,
                NomApels = nombreApel
                
            };

            Cientificos.AddCientificos(c);

            Dni.Clear();
            Nombre.Clear();
        }
    }
}
