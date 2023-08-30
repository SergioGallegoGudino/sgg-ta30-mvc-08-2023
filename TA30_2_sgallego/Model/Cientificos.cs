using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA30_2_sgallego.Model
{
    internal class Cientificos
    {
        private static List<Cientificos> listaCientificos = new List<Cientificos>();

        public static void UpdateCientificos(Cientificos c)
        {
            try
            {
                int indice = listaCientificos.FindIndex(cientificos => cientificos.Dni == c.Dni);
                listaCientificos[indice] = c;
            }
            catch (Exception) 
            {
                MessageBox.Show("Error, inténtelo de nuevo");
            }
        }

        public static void AddCientificos(Cientificos c)
        {
            try
            {
                listaCientificos.Add(c);
            }
            catch (Exception)
            {
                MessageBox.Show("Error, inténtelo de nuevo");
            }
        }

        public static void DeleteCientificos(String dni)
        {
            try
            {
                int index = listaCientificos.FindIndex(cientificos => cientificos.Dni == dni);
                listaCientificos.RemoveAt(index);
                Asignado.borrarAsignadoCientifico(dni);
            }
            catch (Exception)
            {
                MessageBox.Show("Error, inténtelo de nuevo");
            }
            
        }

        public static List<Cientificos> GetCientificos()
        {
            return listaCientificos;
        }

        public String Dni { get; set; }

        public String NomApels { get; set; }

    }
}
