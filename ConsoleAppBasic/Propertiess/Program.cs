using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propertiess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado Taka = new Empleado("Taka");
            Taka.SALARY = 1200;
            Console.WriteLine("El salario actual es de: " + Taka.SALARY);
            Console.WriteLine("Se le agregan +500.74");
            Taka.SALARY += 500.74;
            Console.WriteLine("El salario final es de: " + Taka.SALARY);

        }
    }
}
