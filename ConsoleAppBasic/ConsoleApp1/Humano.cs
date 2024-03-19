using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Humano : Mamiferos
    {
        private string nombreHumano;

        public Humano(string nombreHumano) : base(nombreHumano)
        {
            this.nombreHumano = nombreHumano;
        }

        public void Razonar()
        {
            Console.WriteLine("Razonando");
        }

        public override void Pensar()
        {
            Console.WriteLine("Pensamiento humano avanzado");
        }
    }
}
