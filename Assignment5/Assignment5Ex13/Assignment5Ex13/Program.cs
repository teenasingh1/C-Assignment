using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment5Ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[20];
            for (int i = 0; i < 20; i++) array[i] = i + 1;
            Console.WriteLine("\n\n Elements :: {0}", string.Join(", ", array));
            Console.WriteLine("\n\n Are All Elements Even :: {0}", string.Join(", ", array.CustomAll(x => x % 2 == 0)));
            Console.WriteLine(" Is Atleast One Element Even :: {0}", string.Join(", ", array.CustomAny(x => x % 2 == 0)));
            Console.WriteLine(" Max Element :: {0}", string.Join(", ", array.CustomMax((x, y) => { if (y > x) return y; return x; })));
            Console.WriteLine(" Min Element :: {0}", string.Join(", ", array.CustomMin((x, y) => { if (y < x) return y; return x; })));
            Console.WriteLine(" Odd Even Elements :: {0}", string.Join(", ", array.CustomWhere(x => x % 2 != 0)));
            Console.WriteLine(" Square Of Elements :: {0}", string.Join(", ", array.CustomSelect(x => x * x)));
            Console.ReadLine();
        }
    }
}