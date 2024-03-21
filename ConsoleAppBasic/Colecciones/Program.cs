using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            List<string> listName = new List<string>();

            Console.WriteLine("Introduce el total de nombres de la lista: ");
            count = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduce uno por uno los nombres para agregar: ");
            for (int i = 0; i < count; i++)
            {
                listName.Add(Console.ReadLine());
            }

            Console.WriteLine("Sus nombres ingresados son: ");
            listName.ForEach(element => Console.WriteLine("- " + element));
        }
    }
}
