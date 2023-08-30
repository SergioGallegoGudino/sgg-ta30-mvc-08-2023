using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TA30_1_sgallego.Model;

namespace TA30_1_sgallego.View
{
    public partial class DeleteVideos : Form
    {
        public DeleteVideos()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Id.Text);
            Video.DeleteVideo(id);
        }
    }
}
