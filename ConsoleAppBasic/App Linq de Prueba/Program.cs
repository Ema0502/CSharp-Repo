using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace App_Linq_de_Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Valores numericos: ");

            //List<int> numerosPares = new List<int>();
            //foreach (int numero in numeros)
            //{
            //    if (numero % 2 == 0) numerosPares.Add(numero);
            //}

            IEnumerable<int> numerosPares = from numero in numeros where numero % 2 == 0 select numero;

            foreach (int numero in numerosPares)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
