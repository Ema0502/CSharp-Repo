using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LIST EXAMPLE
            int count = 0;
            List<string> listName = new List<string>();

            Console.WriteLine("Introduce el total de nombres de la lista: ");
            count = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduce uno por uno los nombres para agregar: ");
            for (int i = 0; i < count; i++)
            {
                listName.Add(Console.ReadLine());
            }

            Console.WriteLine("Sus nombres ingresados son: ");
            listName.ForEach(element => Console.WriteLine("- " + element));


            //LINKEDLIST EXAMPLE
            int[] arrayNumbersForLL = new int[] { 2, 3, 5, 7 };
            LinkedList<int> ListNode = new LinkedList<int>();

            foreach (int number in arrayNumbersForLL)
            {
                ListNode.AddFirst(number);
            }

            for (LinkedListNode<int> nodo = ListNode.First; nodo != null; nodo = nodo.Next)
            {
                int number = nodo.Value;
                Console.WriteLine(number);
            }

            //QUEUE EXAMPLE
            int[] arrayNumbersForQueue = new int[] { 12,376, 15, 37 };
            Queue<int> myQueue = new Queue<int>();

            foreach (int element in arrayNumbersForQueue)
            {
                Console.WriteLine("agregando el elemento " + element);
                myQueue.Enqueue(element);
                Console.WriteLine("elemento agregado, cantidad actual = " + myQueue.Count);
            }
            
            while (myQueue.Count > 0)
            {
                Console.WriteLine("quitando el elemento: ");
                myQueue.Dequeue();
                Console.WriteLine("cantidad actual = " + myQueue.Count);
            }

            //STACK EXAMPLE
            
            int[] arrayNumbersForStack = new int[] { 12, 376, 15, 37 };
            Stack<int> numbersStack = new Stack<int>();
            foreach(int number in arrayNumbersForStack)
            {
                numbersStack.Push(number);
                Console.WriteLine("numero agregado, cantidad actual: " + numbersStack.Count);
            }

            Console.WriteLine("eliminando numero...");
            numbersStack.Pop();
            Console.WriteLine("cantidad actual de elementos en el stack: " + numbersStack.Count);
            
            //DICTIONARY EXAMPLE

            Dictionary<string, int> personas = new Dictionary<string, int>();
            personas.Add("Messi", 36);
            personas.Add("Hazard", 30);
            personas["Jordan"] = 40;
            personas["Yuzu"] = 29;
            foreach (KeyValuePair<string, int> persona in personas)
            {
                Console.WriteLine("Nombre: " + persona.Key + ", Edad " + persona.Value);
                Console.WriteLine("Nombre: {0}, Edad: {1}", persona.Key, persona.Value);
            }
        }
    }
}
