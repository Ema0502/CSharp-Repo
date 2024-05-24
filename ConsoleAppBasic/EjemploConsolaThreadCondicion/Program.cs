using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EjemploConsolaThreadCondicion
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var tareaRealizada = new TaskCompletionSource<bool>();
      var hilo1 = new Thread(() =>
      {
        for (int i = 0; i < 3; i++)
        {
          Console.WriteLine("hilo 1");
          Thread.Sleep(1000);
        }
        tareaRealizada.TrySetResult(true);
      });

      var hilo2 = new Thread(() =>
      {
        for (int i = 0; i < 3; i++)
        {
          Console.WriteLine("hilo 2");
          Thread.Sleep(1000);
        }
      });

      hilo1.Start();
      var resultadoTarea = tareaRealizada.Task.Result;
      // tareaRealizada.Task.Wait(); // Esperar a que la tarea se complete sin usar el resultado.
      hilo2.Start();
    }
  }
}