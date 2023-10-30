using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Excercise5
{
    public class Rubber : IDuck, IFly, IQuack
    {
        public string Fly { get; set; }
        public string Quack { get; set; }
        public Rubber(int weight, int noOfWings)
        {
            _weight = weight;
            NoOfWings = noOfWings;
            Quack = "don't Quack";
            Fly = "don't Fly";
            TypeOfDuck = "Rubber Ducks";
        }
    }
}