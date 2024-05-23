using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EjemploConsolaThreards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //al ejecutar los hilos, el sistema no cumple estrictamente el mismo tiempo de ejecucion para cada proceso
            Thread threadExample = new Thread(MetodoSaludo);
            threadExample.Start();
            //sincronizacion
            threadExample.Join();

            Console.WriteLine("Hola mundo, thread");
            Thread.Sleep(500);
            Console.WriteLine("Hola mundo, thread");
            Thread.Sleep(500); 
            Console.WriteLine("Hola mundo, thread");
            Thread.Sleep(500);
        }

        static void MetodoSaludo()
        {
            Console.WriteLine("Hola mundo, thread 2");
            Thread.Sleep(500);
            Console.WriteLine("Hola mundo, thread 2");
            Thread.Sleep(500);
            Console.WriteLine("Hola mundo, thread 2");
            Thread.Sleep(500);
        }
    }
}
