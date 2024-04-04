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
            //Delegate
            ExampleDelegate MyDelegate = new ExampleDelegate(Saludo.FnSaludo);
            MyDelegate();
            MyDelegate = new ExampleDelegate(Despedida.FnDespedida);
            MyDelegate();

            //Predicate

            List<int> listPares = new List<int>();
            listPares.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            Predicate<int> predicatePares = new Predicate<int>(Pares);

            List<int> numPares = listPares.FindAll(predicatePares);

            foreach (int num in numPares)
            {
                Console.WriteLine(num);
            }
        }

        static bool Pares(int num)
        {
            if (num % 2 == 0) return true;
            return false;
        }


    }
}
