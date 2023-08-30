using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA30_2_sgallego.View
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateCientifico view = new CreateCientifico();
            view.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadCientifico view = new ReadCientifico();
            view.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateCientifico view = new UpdateCientifico();
            view.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteCientifico view = new DeleteCientifico();
            view.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CreateProyecto view = new CreateProyecto();
            view.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReadProyecto view = new ReadProyecto();
            view.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UpdateProyecto view = new UpdateProyecto();
            view.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DeleteProyecto view = new DeleteProyecto();
            view.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AsignarProyecto view = new AsignarProyecto();
            view.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            VerAsignados view = new VerAsignados();
            view.Show();
        }
    }
}
