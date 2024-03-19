using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico2
{
    class Coche: Vehiculo
    {
        public override void Conducir()
        {
            Console.WriteLine("Conduciendo en calle");
        }
        public void Reversa()
        {
            Console.WriteLine("Retrocediendo");
        }
    }
}
