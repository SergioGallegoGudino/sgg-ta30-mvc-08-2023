using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA30_2_sgallego.Model
{

    public class Proyecto
    {
        private static List<Proyecto> listaProyectos = new List<Proyecto>();

        public static void DeleteProyecto(String id)
        {
            try
            {
                int index = listaProyectos.FindIndex(proyecto => proyecto.Id == id);
                listaProyectos.RemoveAt(index);
                Asignado.borrarAsignadoProyecto(id);

            }
            catch (Exception)
            {
                MessageBox.Show("Error, inténtelo de nuevo");
            }

        }

        public static void UpdateProyecto(Proyecto p)
        {
            try
            {
                int indice = listaProyectos.FindIndex(proyecto => proyecto.Id == p.Id);
                listaProyectos[indice] = p;
            }
            catch (Exception)
            {
                MessageBox.Show("Error, inténtelo de nuevo");
            }
        }

        public static void AddProyecto(Proyecto p)
        {
            listaProyectos.Add(p);
        }

        public static List<Proyecto> GetProyectos()
        {
            return listaProyectos;
        }

        public String Id { get; set; }

        public String Nombre { get; set; }

        public int Horas { get; set; }
    }
}

    
