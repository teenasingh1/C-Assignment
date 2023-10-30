using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmemt1Ex3
{
    class Program
    {
        
        public static Boolean isPrime(int p)
        {
            for (int i = 2; i * i <= p; i++)
            {
                if (p % i == 0)
                    return false;
            }
            return true;
        }
        public static void Fun(int p, int b)
        {
            Console.WriteLine("Primes in between " + p + " " + b);
            for (int i = p; i <= b; i++)
            {
                if (isPrime(i))
                    Console.WriteLine(i + " ");
            }

        }
        public static void Main(string[] args)
        {
            int p, b;
            do
            {
                Console.WriteLine("Enter two numbers to find prime");
                p = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());

                if (p < b)
                {
                    Fun(p, b);
                    return;
                }
            } while (p>b);
        }
    }
}

