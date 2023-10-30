using System;


namespace Assignment
{
    public enum TypeOfEquipment { Mobile, Immobile }
    abstract class Equipment
    {
        public string Name, Description;
        public int DistanceMoveTillDate = 0, MaintainceCost = 0;
        public TypeOfEquipment EquipmentType;
        public abstract void MoveBy(int Distance);
        public abstract void ShowDetail();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Mode of Transport i.e 1. Mobile or 2. Immobile");
            string Mode = Console.ReadLine();
            if (Mode == "Mobile" || Mode == "1")
            {
                Console.WriteLine("Enter Name");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter Description ");
                string description = Console.ReadLine();
                Console.WriteLine("Enter Disatnce Move Till Data");
                int dist = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Maintaince Cost");
                int mainCost = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Number of wheel");
                int wheel = Convert.ToInt32(Console.ReadLine());
                Mobile obj = new Mobile(Name, description, dist, mainCost, wheel);
                obj.ShowDetail();
            }
            else if (Mode == "Immobile" || Mode == "2")
            {
                Console.WriteLine("Enter Name");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter Description ");
                string description = Console.ReadLine();
                Console.WriteLine("Enter Disatnce Move Till Data");
                int dist = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Maintaince Cost");
                int mainCost = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Weight");
                int weight = Convert.ToInt32(Console.ReadLine());
                Immobile obj = new Immobile(Name, description, dist, mainCost, weight);
                obj.ShowDetail();
            }
            else
            {
                Console.WriteLine("Invalid Option.. \nExiting.. ");
            }
        }
    }
    class Mobile : Equipment
    {
        int NumberOfWheel = 0;
        public Mobile(string NameDuck, string Descrip, int Date, int Maintaince, int wheel)
        {
            Name = NameDuck;
            Description = Descrip;
            DistanceMoveTillDate = Date;
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
            Console.WriteLine("\nName:- " + Name);
            Console.WriteLine("Description:- " + Description);
            Console.WriteLine("Disatnce Move Till Data:- " + DistanceMoveTillDate);
            Console.WriteLine("Maintaince Cost:- " + MaintainceCost);
            Console.WriteLine("Number of wheel: " + NumberOfWheel);
        }
    }
    class Immobile : Equipment
    {
        int Weight = 0;
        public Immobile(string NameDuck, string Descrip, int Date, int Maintaince, int Weigh)
        {
            Name = NameDuck;
            Description = Descrip;
            DistanceMoveTillDate = Date;
            MaintainceCost = Maintaince;
            Weight = Weigh;
            EquipmentType = TypeOfEquipment.Immobile;
        }
        public override void MoveBy(int Distance)
        {
            DistanceMoveTillDate += Distance;
            MaintainceCost += (Weight * Distance);
        }
        public override void ShowDetail()
        {
            Console.WriteLine("Name " + Name);
            Console.WriteLine("Description " + Description);
            Console.WriteLine("Disatnce Move Till Data " + DistanceMoveTillDate);
            Console.WriteLine("Maintaince Cost " + MaintainceCost);
            Console.WriteLine("Total Weight " + Weight);
        }
    }
}

