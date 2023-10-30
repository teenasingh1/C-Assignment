using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Excercise6
{
    public class EquipmentInventory
    {
        List<Mobile> ListOfMobileEquipment = new List<Mobile>();
        List<Immobile> ListOfImmobileEquipment = new List<Immobile>();
        public void CreateListOfMobileEquipment()
        {
            Console.WriteLine("Enter the Detail for Creating of Assignment");
            Console.WriteLine("Enter the Name of Mobile Equipment:-");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the Description of Mobile Equipment:-");
            string Description = Console.ReadLine();
            Console.WriteLine("Enter the Number of Wheel in Mobile Equipment:-");
            int Wheel = Convert.ToInt32(Console.ReadLine());
            Mobile obj = new Mobile(Name, Description, 0, 0, Wheel);
            ListOfMobileEquipment.Add(obj);
        }
        public void CreateListOfImmobileEquipment()
        {
            Console.WriteLine("Enter the Detail for Creating of Assignment");
            Console.WriteLine("Enter the Name of Immobile Equipment:- ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the Description of Immobile Equipment:-");
            string Description = Console.ReadLine();
            Console.WriteLine("Enter the Number of Weight in Immobile Equipment:-");
            int Weight = Convert.ToInt32(Console.ReadLine());
            Immobile obj = new Immobile(Name, Description, 0, 0, Weight);
            ListOfImmobileEquipment.Add(obj);
        }
        public void DeleteAllMobileEquipment()
        {
            ListOfMobileEquipment.Clear();
        }
        public void DeleteAllImmobileEquipment()
        {
            ListOfImmobileEquipment.Clear();
        }
        public void DeleteAllEquipment()
        {
            DeleteAllMobileEquipment();
            DeleteAllImmobileEquipment();
        }
        public void DeleteAEquipment()
        {
            try
            {
                Console.WriteLine("Enter the Type Of Equipment 1:Mobile 2:Immobile");
                string Type = Console.ReadLine();
                if (Type == "Mobile")
                {
                    Console.WriteLine("Enter the Name Of the equipment you want to Delete.");
                    String NameToDelete = Console.ReadLine();
                    bool flag = false;
                    foreach (var item in ListOfMobileEquipment)
                    {
                        if (item.Name == NameToDelete)
                        {
                            ListOfMobileEquipment.Remove(item);
                            flag = true;
                            break;
                        }
                    }
                    if (flag == false)
                    {
                        Console.WriteLine("Given Name of Immobile Type Equiment Not Found in a List");
                    }
                }
                else if (Type == "Immobile")
                {
                    bool flag = false;
                    Console.WriteLine("Enter the Name Of the equipment you want to Delete.");
                    String NameToDelete = Console.ReadLine();
                    foreach (var item in ListOfImmobileEquipment)
                    {
                        if (item.Name == NameToDelete)
                        {
                            ListOfImmobileEquipment.Remove(item);
                            flag = true;
                            break;
                        }
                    }
                    if (flag == false)
                    {
                        Console.WriteLine("Given Name of Immobile Type Equiment Not Found in a List");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Your Havn't Create the List Of Equipment Please Create it First");
            }
        }
        public void ListAllEquipment()
        {
            foreach (var item in ListOfMobileEquipment)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Description);
                Console.WriteLine();
            }
            foreach (var item in ListOfImmobileEquipment)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Description);
                Console.WriteLine();
            }
        }
        enum Property { Description, Wheel, Weight, MaintainceCost, DistanceMoveTillDate }
        public void ListAllEquipmentNotMovedTillNow()
        {
            Console.WriteLine("List Of Equipment Not Moved Till Now");
            foreach (var item in ListOfImmobileEquipment)
            {
                if (item.DistanceMoveTillDate == 0)
                {
                    item.ShowDetail();
                    Console.WriteLine();
                }
            }
            foreach (var item in ListOfMobileEquipment)
            {
                if (item.DistanceMoveTillDate == 0)
                {
                    item.ShowDetail();
                    Console.WriteLine();
                }
            }
        }
        public void ShowDetailOfEquipment()
        {
            foreach (var item in ListOfMobileEquipment)
            {
                item.ShowDetail();
                Console.WriteLine();
            }
            foreach (var item in ListOfImmobileEquipment)
            {
                item.ShowDetail();
                Console.WriteLine();
            }
        }
        public void UpdateMoveDate()
        {
            Console.WriteLine("Update");
            Console.WriteLine("Enter the Type of Equipment");
            string Type = Console.ReadLine();
            if (Type == "Mobile")
            {
                Console.WriteLine("Enter the Name of Equpment");
                string name = Console.ReadLine();
                foreach (var item in ListOfMobileEquipment)
                {
                    if (item.Name == name)
                    {
                        Console.WriteLine("Enter the Update Move Data");
                        int Value = Convert.ToInt32(Console.ReadLine());
                        item.MoveBy(Value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                }
            }
            else if (Type == "Immobile")
            {
                Console.WriteLine("Enter the Name of Equipment");
                string name = Console.ReadLine();
                foreach (var item in ListOfImmobileEquipment)
                {
                    if (item.Name == name)
                    {
                        Console.WriteLine("Enter the Update Move Data");
                        int Value = Convert.ToInt32(Console.ReadLine());
                        item.MoveBy(Value);
                    }
                }
            }
        }
    }
}