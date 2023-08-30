using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA30_2_sgallego.Model
{
    internal class Asignado
    {
        private static List<Asignado> listaAsignados = new List<Asignado>();

        public String Id { get; set; }

        public String Dni{ get; set; }

        public static void AsignarProyecto(String dni, String id)
        {
            try
            {
                Asignado a = new Asignado
                {
                    Id = id,
                    Dni = dni
                };
                listaAsignados.Add(a);
            }
            catch (Exception)
            {
                MessageBox.Show("Error, inténtelo de nuevo");
            }
        }

        public static void borrarAsignadoCientifico(String dni)
        {
            try
            {
                Boolean eliminados = false;
                while (!eliminados)
                {
                    int indice = listaAsignados.FindIndex(asignados => asignados.Dni == dni);
                    if (indice != -1)
                    {
                        listaAsignados.RemoveAt(indice);
                    }
                    else
                    {
                        eliminados = true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error, inténtelo de nuevo");
            }
        }

        public static void borrarAsignadoProyecto(String id)
        {
            try
            {
                Boolean eliminados = false;
                while (!eliminados)
                {
                    int indice = listaAsignados.FindIndex(asignados => asignados.Id== id);
                    if (indice != -1)
                    {
                        listaAsignados.RemoveAt(indice);
                    }
                    else
                    {
                        eliminados = true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error, inténtelo de nuevo");
            }
        }

        public static List<Asignado> GetAsignados()
        {
            return listaAsignados;
        }
    }
}
