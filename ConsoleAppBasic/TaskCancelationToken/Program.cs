using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskCancelationToken
{
  internal class Program
  {
    private static int acumulador = 0;
    static void Main(string[] args)
    {
      CancellationTokenSource cTokenSource = new CancellationTokenSource();
      CancellationToken cancelToken = cTokenSource.Token;

      Task tarea = Task.Run(() => RealizarTarea(cancelToken));

      for (int i = 0; i < 25; i++)
      {
        acumulador += 5;
        Thread.Sleep(1000);
        if (acumulador > 10)
        {
          cTokenSource.Cancel();
          break;
        }
      }

      Console.ReadLine();
    }

    static void RealizarTarea(CancellationToken token)
    {
      for (int i = 0; i < 25; i++)
      {
        acumulador++;
        int idThread = Thread.CurrentThread.ManagedThreadId;
        Thread.Sleep(1000);
        Console.WriteLine("Ejecutando tarea {0}", idThread);
        Console.WriteLine(acumulador);

        if (token.IsCancellationRequested)
        {
          acumulador = 0;
          Console.WriteLine("Cancelacion activada, acumulador vale: " + acumulador);
          return;
        }
      }
    }
  }
}
