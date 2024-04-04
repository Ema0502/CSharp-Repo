using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosPredicadosLambdas
{
    internal class Program
    {
        delegate void ExampleDelegate();
        static void Main(string[] args)
        {
            ExampleDelegate MyDelegate = new ExampleDelegate(Saludo.FnSaludo);
            MyDelegate();
            MyDelegate = new ExampleDelegate(Despedida.FnDespedida);
            MyDelegate();
        }
    }
}
