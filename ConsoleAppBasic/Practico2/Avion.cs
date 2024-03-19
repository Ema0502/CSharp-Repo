using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico2
{
    class Avion: Vehiculo
    {
        public override void Conducir()
        {
            Console.WriteLine("Volando");
        }
        
        public void Aterrizar()
        {
            Console.WriteLine("Aterrizando en pista");
        }
    }
}
