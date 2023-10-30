using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment4Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue2<string> queue = new PriorityQueue2<string>();
            queue.Priority = 1;
            queue.Enqueue("test");
            System.Console.WriteLine("\n Adding element Priority:: 1\n element:: test\n");
            queue.Priority = 5;
            queue.Enqueue("test2");
            System.Console.WriteLine("\n Adding element Priority:: 5\n element:: test2\n");
            System.Console.WriteLine(" Peak:: {0}\n Count:: {1}", queue.Peek(), queue.Count());
            queue.Priority = 5;
            queue.Enqueue("test3");
            System.Console.WriteLine("\n Adding element Priority:: 5\n element:: test3\n");
            queue.Priority = 2;
            queue.Enqueue("test4");
            System.Console.WriteLine("\n Adding element Priority:: 2\n element:: test4\n");
            System.Console.WriteLine(" Peak:: {0}\n Count:: {1}", queue.Peek(), queue.Count());
            queue.Priority = 23;
            queue.Enqueue("test5");
            System.Console.WriteLine("\n Adding element Priority:: 23\n element:: test5\n");
            queue.Dequeue();
            System.Console.WriteLine(" Dequeue called\n");
            System.Console.WriteLine(" Peak:: {0}\n Count:: {1}\n", queue.Peek(), queue.Count());
            System.Console.WriteLine(" Contains('test'):: {0}\n Contains('test5'):: {1}", queue.Contains("test"), queue.Contains("test5"));
            Console.ReadLine();
        }
    }
}