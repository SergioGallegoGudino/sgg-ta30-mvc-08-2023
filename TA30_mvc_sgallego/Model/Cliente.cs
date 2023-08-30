using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TA30_mvc_sgallego.Model {
    public class Cliente
    {
        private static List<Cliente> listClientes = new List<Cliente>();

        public static void EditCliente(Cliente clienteEdit)
        {
            int indice = listClientes.FindIndex(cliente => cliente.Id == clienteEdit.Id);
            listClientes[indice] = clienteEdit;
        }
        public static void DeleteCliente(int id)
        {
            int indice = listClientes.FindIndex(cliente => cliente.Id == id);
            listClientes.RemoveAt(indice);
        }
        public static void AddCliente(Cliente cliente)
        {
            listClientes.Add(cliente);
        }

        public static List<Cliente> GetClientes()
        {
            return listClientes;
        }

        [Key]
        public int Id { get; set; }

        public String Nombre { get; set; }

        public String Apellido { get; set; }

        public String Direccion { get; set; }

        public int Dni { get; set; }

        public DateTime Fecha { get; set; }
    }
}
