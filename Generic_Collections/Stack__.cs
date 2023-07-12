using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections
{
    public class Stack__
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(42);
            stack.Push(43);
            stack.Push(50);
            stack.Push(51);

            foreach (int i in stack)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            stack.Pop();
            foreach (int i in stack)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nPeek Element= " + stack.Peek());
            Console.WriteLine();

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(42);
            queue.Enqueue(43);
            queue.Enqueue(50);
            queue.Enqueue(51);

            foreach (int i in queue)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            queue.Dequeue();


            foreach (int i in queue)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nPeek Element= " + queue.Peek());

        }
    }
}
