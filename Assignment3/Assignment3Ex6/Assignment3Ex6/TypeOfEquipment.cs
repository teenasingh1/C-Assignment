
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Excercise6
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
}

