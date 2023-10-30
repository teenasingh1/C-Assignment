using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6Ex14
{
    public class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            Product product = new Product(1, 2345, 12);
            Product product0 = new Product(2, 43, 3);
            Product product1 = new Product(3, 68, 89);
            Product product2 = new Product(4, 3456, 1);
            Product product3 = new Product(5, 23444, 45);
            inventory.AddProduct("one", product);
            inventory.AddProduct("two", product0);
            inventory.UpdateProduct("one", 62);
            inventory.AddProduct("three", product1);
            inventory.AddProduct("four", product2);
            inventory.UpdateProduct("three", 4534f);
            inventory.AddProduct("five", product3);
            inventory.UpdateProduct("five", 12f);
            inventory.UpdateProduct("five", 60);
            inventory.RemoveProduct("four");
            System.Console.WriteLine("\n\n Final Value:: {0}", inventory.value);
        }
    }
}
