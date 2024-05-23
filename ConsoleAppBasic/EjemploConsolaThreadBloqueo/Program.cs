using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EjemploConsolaThreadBloqueo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria CuentaFamilia = new CuentaBancaria(2000);

            Thread[] hilosPersonas = new Thread[18];

            for (int i = 0; i < hilosPersonas.Length; i++)
            {
                Thread threadI = new Thread(CuentaFamilia.RetirarDineroInicial);
                //nombre para el hilo
                threadI.Name = i.ToString();

                hilosPersonas[i] = threadI;
            }

            for (int i = 0; i < hilosPersonas.Length; i++)
            {
                hilosPersonas[i].Start();
                hilosPersonas[i].Join();
            }

        }
    }
}
