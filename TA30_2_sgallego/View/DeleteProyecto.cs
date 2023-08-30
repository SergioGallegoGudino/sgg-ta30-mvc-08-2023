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

namespace TA30_2_sgallego.View
{
    public partial class DeleteProyecto : Form
    {
        public DeleteProyecto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String id = Id.Text;
            Model.Proyecto.DeleteProyecto(id);
            Id.Clear();
        }
    }
}
