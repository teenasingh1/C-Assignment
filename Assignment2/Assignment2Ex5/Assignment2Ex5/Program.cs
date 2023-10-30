using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Excercise5
{
    public interface IFly
    {
        string Fly { get; set; }
    }
    public interface IQuack
    {
        string Quack { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rubber obj = new Rubber(10, 20);
            obj.ShowDetail();
            Mallard obj1 = new Mallard(15, 25);
            Console.WriteLine(obj1.Fly);
            obj1.ShowDetail();
            Console.ReadLine();
        }
    }
}