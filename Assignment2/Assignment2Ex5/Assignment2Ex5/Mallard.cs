using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Excercise5
{
    public class Mallard : IDuck, IFly, IQuack
    {
        public string Fly { get; set; }
        public string Quack { get; set; }
        public Mallard(int weight, int noOfWings)
        {
            _weight = weight;
            NoOfWings = noOfWings;
            Quack = "Quack Loud";
            Fly = "Fast Fly";
            TypeOfDuck = "Mallard Ducks";
        }
    }
}