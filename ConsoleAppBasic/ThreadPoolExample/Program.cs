using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPoolExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      for (int i = 0; i < 50; i++)
      {
        //Thread threadExample = new Thread(HacerTarea);
        //threadExample.Start();

        //el pool necesita que la cb reciba un obj
        ThreadPool.QueueUserWorkItem(HacerTarea, i);

      }
      Console.ReadLine();
    }

    static void HacerTarea(object objPool)
    {
      int numFor = (int)objPool;
      Console.WriteLine($"El thread {Thread.CurrentThread.ManagedThreadId} ha iniciado la tarea Nº " + numFor);
      Thread.Sleep( 1000 );
      Console.WriteLine($"El thread {Thread.CurrentThread.ManagedThreadId} con la tarea Nº {numFor} ha finalizado");
    }
  }
}
