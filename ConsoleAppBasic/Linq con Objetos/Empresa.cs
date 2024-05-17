using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_con_Objetos
{
    internal class Empresa
    {
        public Empresa() { }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public void ObtenerDatosEmpresa()
        {
            Console.WriteLine("Empresa: {0}, con Id: {1}", Nombre, Id);
        }
    }
}
