using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // conversion one
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number is : " + s);
            // conversion two
            int t = int.Parse(Console.ReadLine());
            Console.WriteLine("The number is : " + t);
            // conversion three
            int u;
            int.TryParse(Console.ReadLine(), out u);
            Console.WriteLine("The number is : " + u);
            // convert string to float
            double v = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The number is : " + v);
            // convert in boolean (true/false)
            Boolean flag =Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("The number is : " + flag);
        }
    }
}
