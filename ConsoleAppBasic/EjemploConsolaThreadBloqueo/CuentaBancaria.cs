using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EjemploConsolaThreadBloqueo
{
    internal class CuentaBancaria
    {
        double Saldo {  get; set; }
        public CuentaBancaria(double saldo)
        {
            this.Saldo = saldo;
        }

        public double RetirarEfectivo(double cantidad)
        {
            if ((this.Saldo - cantidad) < 0)
            {
                Console.WriteLine($"Mis disculpas, el saldo actual es de {this.Saldo}");
                return this.Saldo;
            }

            Console.WriteLine("Retirado: {0}, quedan {1} en la cuenta", cantidad, this.Saldo);
            Saldo -= cantidad;
            return Saldo;
        }
    }
}
