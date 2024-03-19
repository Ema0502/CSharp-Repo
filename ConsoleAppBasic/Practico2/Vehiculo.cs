using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico2
{
    class Vehiculo
    {
        public void ArrancarMotor()
        {
            Console.WriteLine("El motor esta arrancando");
        }

        public void PararMotor()
        {
            Console.WriteLine("Motor detenido");
        }
        public virtual void Conducir()
        {
            Console.WriteLine("Conduciendo de forma predeterminada");
        }
    }
}
