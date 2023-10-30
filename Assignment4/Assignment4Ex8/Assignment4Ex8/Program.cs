﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment4Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue<string> queue = new PriorityQueue<string>();
            queue.Enqueue(1, "test");
            System.Console.WriteLine("\n Adding element Priority:: 1\n element:: test\n");
            queue.Enqueue(5, "test2");
            System.Console.WriteLine("\n Adding element Priority:: 5\n element:: test2\n");
            System.Console.WriteLine(" Peak:: {0}\n Count:: {1}", queue.Peek(), queue.Count());
            queue.Enqueue(5, "test3");
            System.Console.WriteLine("\n Adding element Priority:: 5\n element:: test3\n");
            queue.Enqueue(2, "test4");
            System.Console.WriteLine("\n Adding element Priority:: 2\n element:: test4\n");
            System.Console.WriteLine(" Peak:: {0}\n Count:: {1}", queue.Peek(), queue.Count());
            queue.Enqueue(23, "test5");
            System.Console.WriteLine("\n Adding element Priority:: 23\n element:: test5\n");
            string pop = queue.Dequeue();
            System.Console.WriteLine(" Dequeue called |  Deleteing {0}", pop);
            System.Console.WriteLine(" Peak:: {0}\n Count:: {1}\n", queue.Peek(), queue.Count());
            System.Console.WriteLine(" Contains('test'):: {0}\n Contains('test5'):: {1}", queue.Contains("test"), queue.Contains("test5"));
            Console.ReadLine();
        }
    }
}