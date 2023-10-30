using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Excercise6
{
    class Mobile : Equipment
    {
        int NumberOfWheel = 0;
        public Mobile(string NameDuck, string Descrip, int dist, int Maintaince, int wheel)
        {
            Name = NameDuck;
            Description = Descrip;
            DistanceMoveTillDate = dist;
            MaintainceCost = Maintaince;
            NumberOfWheel = wheel;
            EquipmentType = TypeOfEquipment.Mobile;
        }
        public override void MoveBy(int Distance)
        {
            DistanceMoveTillDate += Distance;
            MaintainceCost += (NumberOfWheel * Distance);
        }
        public override void ShowDetail()
        {
            Console.WriteLine("Name Equipment type:- " + Name);
            Console.WriteLine("Equipment's description:- " + Description);
            Console.WriteLine("Total Disatnce Moved :- " + DistanceMoveTillDate);
            Console.WriteLine("Maintaince Cost:- " + MaintainceCost);
            Console.WriteLine("Wheel's count: " + NumberOfWheel);
        }
    }
}