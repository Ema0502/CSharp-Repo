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
        private object _bloqueoSaldoPositivo = new object();
        double Saldo {  get; set; }
        public CuentaBancaria(double saldo)
        {
            this.Saldo = saldo;
        }

        public double RetirarEfectivo(double cantidad)
        {
            if ((this.Saldo - cantidad) < 0)
            {
                Console.WriteLine($"Mis disculpas, el saldo actual es de {this.Saldo}. Hilo: {Thread.CurrentThread.Name}");
                return this.Saldo;
            }

            lock (_bloqueoSaldoPositivo)
            {
                if (this.Saldo >= cantidad)
                {
                    Console.WriteLine("Retirado: {0}, quedan {1} en la cuenta {2}", cantidad, this.Saldo, Thread.CurrentThread.Name);
                    Saldo -= cantidad;
                }
            }
            return Saldo;
        }

        public void RetirarDineroInicial()
        {
            this.RetirarEfectivo(500);
        }
    }
}
