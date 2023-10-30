using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Excercise7
{
    class Duck
    {
        List<IDuck> ListOfDuck = new List<IDuck>();
        public void AddDuck()
        {
            Console.WriteLine("Enter the Weight of Duck");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Number Of Wings of Duck");
            int noOfWings = Convert.ToInt32(Console.ReadLine());
            IDuck obj = new IDuck();
            obj.Weight = weight;
            obj.NoOfWings = noOfWings;
            ListOfDuck.Add(obj);
        }
        public void RemoveADuck()
        {
            Console.WriteLine("Choose on Basis of which Criteria you want to remove the Duck from list 1.By Weight 2.By Number Of Wings");
            string Choice = Console.ReadLine();
            bool flag = false;
            try
            {
                if (Choice == "By Weight")
                {
                    Console.WriteLine("Enter the Weight Of Your Duck");
                    int weight = Convert.ToInt32(Console.ReadLine());
                    foreach (var item in ListOfDuck)
                    {
                        if (item.Weight == weight)
                        {
                            ListOfDuck.Remove(item);
                            flag = true;
                            break;
                        }
                    }
                }
                else if (Choice == "By Number Of Wings")
                {
                    Console.WriteLine("Enter the Number Of Wings Of Your Duck");
                    int noOfWings = Convert.ToInt32(Console.ReadLine());
                    foreach (var item in ListOfDuck)
                    {
                        if (item.Weight == noOfWings)
                        {
                            ListOfDuck.Remove(item);
                            flag = true;
                            break;
                        }
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("Duck According To Your Given Data does not Exist in List");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error Occur in Program");
            }
        }
        public void RemoveAllDucks()
        {
            ListOfDuck.Clear();
        }
        public void SortAccordingToWeight()
        {
            ListOfDuck.Sort((object1, object2) => object1.Weight.CompareTo(object2.Weight));
        }
        public void ShowAllDucks()
        {
            foreach (var item in ListOfDuck)
            {
                Console.WriteLine("Weight of Duck: " + item.Weight);
                Console.WriteLine("No. Of Wings in a Duck: " + item.NoOfWings);
                Console.WriteLine();
            }
        }
        public void SortAccordingToNoOfWings()
        {
            ListOfDuck.Sort((object1, object2) => object1.NoOfWings.CompareTo(object2.NoOfWings));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Duck obj = new Duck();
            obj.AddDuck();
            obj.AddDuck();
            obj.AddDuck();
            obj.ShowAllDucks();
            Console.WriteLine("Sorted ducks");
            obj.SortAccordingToNoOfWings();
            obj.ShowAllDucks();
            obj.RemoveADuck();
            Console.WriteLine("After Removal");
            obj.ShowAllDucks();
            Console.ReadLine();
        }
    }
}