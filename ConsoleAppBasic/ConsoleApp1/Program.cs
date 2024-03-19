using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Humano Pepe = new Humano("Pepe Argento");
            Pepe.Respirar();
            Pepe.GetName();

            //principio de sustitucion
            Mamiferos animal = new Caballo("Jay");
            animal.Respirar();

            Mamiferos[] almacenMamiferos = new Mamiferos[2];
            almacenMamiferos[0] = Pepe;
            almacenMamiferos[1] = animal;

            //polimorfismo new virtual o override

            for (int i = 0; i < almacenMamiferos.Length; i++)
            {
                almacenMamiferos[i].Pensar();
            }

            Lagartija When = new Lagartija("When");
            When.GetName();


        }
    }
}
