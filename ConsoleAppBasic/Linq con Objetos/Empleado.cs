using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_con_Objetos
{
    internal class Empleado
    {
        public Empleado() { }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }
        // FK
        public int EmpesaId { get; set; }

        public void ObtenerDatosEmpleado()
        {
            Console.WriteLine("Empleado: {0}, Id: {1}, Cargo: {2}, Salario: {3}, Pertenece a la empresa: {4}", Nombre, Id, Cargo, Salario, EmpesaId);
        }
    }
}
