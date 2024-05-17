using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_con_Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ControlEmpresasEmpleados CE = new ControlEmpresasEmpleados();
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Ingrese el id de una empresa para buscar sus empleados disponibles");
            string valorBusqueda = Console.ReadLine();
            int idConvertido = Convert.ToInt32(valorBusqueda);
            CE.ObtenerEmpleadosId(idConvertido);
        }
    }
}
