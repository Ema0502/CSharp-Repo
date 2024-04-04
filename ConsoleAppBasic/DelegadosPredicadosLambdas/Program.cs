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

            List<Personas> gente = new List<Personas>();
            Personas P1 = new Personas();
            P1.Nombre = "messi";
            P1.Edad = 36;
            Personas P2 = new Personas();
            P2.Nombre = "hazard";
            P2.Edad = 33;
            Personas P3 = new Personas();
            P3.Nombre = "colo";
            P3.Edad = 18;
            gente.AddRange(new Personas[] { P1, P2, P3});

            Predicate<Personas> MiPredPersonas = new Predicate<Personas>(ExisteMessi);

            bool respExiste = gente.Exists(MiPredPersonas);
            if (respExiste) Console.WriteLine("el messias existe");
            else Console.WriteLine("messi no existe, se rompe la realidad");
        }
        //Fn
        static bool Pares(int num)
        {
            if (num % 2 == 0) return true;
            return false;
        }

        static bool ExisteMessi (Personas persona)
        {
            if (persona.Nombre.ToLower() == "messi") return true;
            return false;
        }
    }
}
