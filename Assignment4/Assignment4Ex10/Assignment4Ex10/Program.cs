using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4Ex10
{
    public class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue3<int> priorityQueue3 = new PriorityQueue3<int>();
            priorityQueue3.Enqueue(10, 2);
            priorityQueue3.Enqueue(2, 4);
            priorityQueue3.Enqueue(1, 7);
            priorityQueue3.Enqueue(30, 6);
            Console.WriteLine("Peek of the PQ");
            Console.WriteLine(priorityQueue3.Peek());
            Console.WriteLine("priority of peek element is");
            int x = priorityQueue3.GetHighestPriority();
            Console.WriteLine(x);
            Console.WriteLine("Dequeue is called, first element of dequeue is deleted");
            
            priorityQueue3.Dequeue();
            Console.WriteLine("Peek of the PQ");
            Console.WriteLine(priorityQueue3.Peek());
            Console.ReadLine();
        }
    }
}
