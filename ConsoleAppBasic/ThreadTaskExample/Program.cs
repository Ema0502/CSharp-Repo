using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTaskExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Task tarea1 = new Task(EjecutarTarea);
      tarea1.Start();

      Task tarea2 = new Task(() =>
      {
        for (int i = 0; i < 10; i++)
        {
          int idThread = Thread.CurrentThread.ManagedThreadId;
          Thread.Sleep(1000);
          Console.WriteLine($"El hilo con ID {idThread} esta ejecutandose");
        }
      });
      tarea2.Start();

      Console.ReadLine();
    }

    static void EjecutarTarea()
    {
      for (int i = 0; i < 10; i++)
      {
        int idThread = Thread.CurrentThread.ManagedThreadId;
        Thread.Sleep(1000);
        Console.WriteLine($"Thread con id {idThread} ejecutando la tarea");
      }
    }
  }
}
