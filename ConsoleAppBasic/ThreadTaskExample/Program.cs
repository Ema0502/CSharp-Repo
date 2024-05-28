using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTaskExample
{
  internal class Program
  {
    private static int acumulador;
    static void Main(string[] args)
    {
      //Task tarea1 = new Task(EjecutarTarea);
      //tarea1.Start();
      //Task tarea1 = Task.Run(() =>
      //{
      //  EjecutarTarea();
      //});

      //Task tarea2 = tarea1.ContinueWith(EjecutarOtraTarea);

      Parallel.For(0, 100, EjecutarTarea);
      
      Console.ReadLine();
    }

    //static void EjecutarTarea()
    //{
    //  for (int i = 0; i < 10; i++)
    //  {
    //    int idThread = Thread.CurrentThread.ManagedThreadId;
    //    Thread.Sleep(1000);
    //    Console.WriteLine($"Thread con id {idThread} ejecutando la tarea");
    //  }
    //}
    //static void EjecutarOtraTarea(Task confirmation)
    //{
    //  for (int i = 0; i < 10; i++)
    //  {
    //    int idThread = Thread.CurrentThread.ManagedThreadId;
    //    Thread.Sleep(1000);
    //    Console.WriteLine($"Thread con id {idThread} inicia ejecucion...");
    //  }
    //}

    static void EjecutarTarea(int dato)
    {
      int idThread = Thread.CurrentThread.ManagedThreadId;
      Console.WriteLine($"Thread con id {idThread} ejecutando la tarea");
      Thread.Sleep(1000);
      if (acumulador % 2 == 0) acumulador += dato;
      else acumulador -= dato;
    }
  }
}
