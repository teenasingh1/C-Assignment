using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Excercise5
{
    public class Redhead : IDuck, IFly, IQuack
    {
        public string Fly { get; set; }
        public string Quack { get; set; }
        public Redhead(int weight, int noOfWings)
        {
            _weight = weight;
            NoOfWings = noOfWings;
            Quack = "Quack Mild";
            Fly = "Fly Slow";
            TypeOfDuck = "RedHead Ducks";
        }
    }
}