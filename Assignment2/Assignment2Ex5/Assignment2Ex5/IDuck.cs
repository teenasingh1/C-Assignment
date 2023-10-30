using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Excercise5
{
    public abstract class IDuck
    {
        public string TypeOfDuck { get; set; }
        public int _weight { get; set; }
        public int NoOfWings { get; set; }
        /*
        public IDuck(int weight, int noOfWings)
        {
            Weight = weight;
            NoOfWings = noOfWings;
        }
        */
        public void ShowDetail()
        {
            Console.WriteLine(TypeOfDuck + " " + _weight + " " + NoOfWings + " ");
        }
    }
}