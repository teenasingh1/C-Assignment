using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace Assignment1
{
    public static class Exercise11
    {

        public class Program
        {
            public static void Main(string[] args)
            {


                int a = 16;
                bool c = a.ISodd();
                Console.WriteLine("a is odd is :-{0}", c);
                bool d = a.ISeven();
                Console.WriteLine("a is even is :-{0}", d);
                bool e = a.Isprime();
                Console.WriteLine("a is prime is:-{0}", e);
                bool f = a.Isdivisible(7);
                Console.WriteLine("a is divisible by b is:-{0}", f);
                Console.WriteLine();


            }
        }


        public static bool ISodd(this int a)
        {
            if (a % 2 != 0) return true;
            else return false;
        }
        public static bool ISeven(this int a)
        {
            if (a % 2 == 0) return true;
            else return false;
        }
        public static bool Isprime(this int a)
        {
            for (int i = 2; i <= a / 2; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool Isdivisible(this int a, int b)
        {
            if ((b != 0) && (a % b == 0)) return true;
            else return false;
        }
    }
}
