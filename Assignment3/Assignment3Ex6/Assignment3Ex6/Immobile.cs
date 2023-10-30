using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Excercise6
{
    class Immobile : Equipment
    {
        int Weight = 0;
        public Immobile(string NameDuck, string Descrip, int Dist, int Maintaince, int weight)
        {
            Name = NameDuck;
            Description = Descrip;
            DistanceMoveTillDate = Dist;
            MaintainceCost = Maintaince;
            Weight = weight;
            EquipmentType = TypeOfEquipment.Immobile;
        }
        public override void MoveBy(int Distance)
        {
            DistanceMoveTillDate += Distance;
            MaintainceCost += (Weight * Distance);
        }
        public override void ShowDetail()
        {
            Console.WriteLine("Name of Equipment:- " + Name);
            Console.WriteLine("Description of Equipment:- " + Description);
            Console.WriteLine("Distance Move Till Date:- " + DistanceMoveTillDate);
            Console.WriteLine("Maintaince Cost:- " + MaintainceCost);
            Console.WriteLine("Total Weight: " + Weight);
        }
    }
}