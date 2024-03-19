using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Mamiferos: Animales
    {
        private string nombreSerVivo;

        public Mamiferos(string nombreSerVivo)
        {
            this.nombreSerVivo = nombreSerVivo;
        }

        public virtual void Pensar()
        {
            Console.WriteLine("Pensamiento basico");
        }

        public void TenerCrias()
        {
            Console.WriteLine("Soy capaz de tener crias");
        }

        public override void GetName()
        {
            Console.WriteLine("El nombre del mamifero es: " + this.nombreSerVivo);
        }
    }
}
