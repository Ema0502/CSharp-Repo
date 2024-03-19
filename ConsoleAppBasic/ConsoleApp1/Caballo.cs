using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Caballo : Mamiferos, IMamiferosTerrestres
    {
        private string nombreCaballo;

        public Caballo(string nombreCaballo) : base(nombreCaballo)
        {
            this.nombreCaballo = nombreCaballo;
        }

        public void Galopar()
        {
            Console.WriteLine("Galopar");
        }

        public int numeroPatas()
        {
            return 3;
        }
    }
}
