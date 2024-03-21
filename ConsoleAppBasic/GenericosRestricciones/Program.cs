using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericosRestricciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlmacenEmpleados<Director> empleados = new AlmacenEmpleados<Director>(1);
            empleados.Agregar(new Director(4500));

            //las restricciones impiden que se rompan reglas establecidas, el siguiente codigo daria error al no cumplir las condiciones de la interface
            //AlmacenEmpleados<Estudiante> estudiantes = new AlmacenEmpleados<Estudiante>(5);
            //estudiantes.Agregar(new Estudiante(18));
        }
    }
}
