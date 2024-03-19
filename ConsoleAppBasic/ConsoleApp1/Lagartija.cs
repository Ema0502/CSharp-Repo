using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Lagartija: Animales
    {
        private string nombreLagartija;

        public Lagartija(string nombre)
        {
            nombreLagartija = nombre;
        }
        public override void GetName()
        {
            Console.WriteLine("Soy un reptil llamado: " + nombreLagartija);
        }
    }
}
