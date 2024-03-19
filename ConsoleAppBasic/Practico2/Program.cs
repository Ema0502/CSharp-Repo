using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provando el avion");
            Avion miAvion = new Avion();
            miAvion.ArrancarMotor();

            Console.WriteLine("Preparando el coche");
            Coche miCoche = new Coche();
            miCoche.ArrancarMotor();
            miCoche.Reversa();
            miCoche.PararMotor();
        }
    }
}
