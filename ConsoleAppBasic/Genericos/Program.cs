using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Se instancia de la clase generica para manejar todo tipo de datos
            AlmacenDeObjetos<string> arrayStrings = new AlmacenDeObjetos<string>(4);
            arrayStrings.Agregar("string de prueba 1");
            arrayStrings.Agregar("otro string");
            AlmacenDeObjetos<DateTime> arrayDateTimes = new AlmacenDeObjetos<DateTime>(5);
            arrayDateTimes.Agregar(new DateTime());
            arrayDateTimes.Agregar(new DateTime());
            arrayDateTimes.Agregar(new DateTime());
        }
    }
}
