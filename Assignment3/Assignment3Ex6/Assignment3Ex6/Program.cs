using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Excercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO EVERYONE");
            EquipmentInventory obj = new EquipmentInventory();
            obj.CreateListOfMobileEquipment();
            obj.ShowDetailOfEquipment();
            obj.ListAllEquipmentNotMovedTillNow();
            obj.UpdateMoveDate();
            obj.ShowDetailOfEquipment();
            obj.UpdateMoveDate();
            obj.ShowDetailOfEquipment();
            Console.ReadLine();
        }
    }
}