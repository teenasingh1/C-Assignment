using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String one = "Happy starting";
            String two = "Happy starting";
            if(one == two)
            {
                Console.WriteLine("both strings are same using ==");
            }
            else
            {
                Console.WriteLine("both strings are different using ==");
            }
            if (one.Equals(two))
            {
                Console.WriteLine("same using equal method");
            }
            else
            {
                Console.WriteLine("not same using equal method");
            }
            var String1 =new StringBuilder();
            String1.Append("hii");
            var String2 = new StringBuilder();
            String2.Append("hii");
            if(String1.Equals(String2)) { }
            Console.WriteLine("welcome");

        }
    }
}
