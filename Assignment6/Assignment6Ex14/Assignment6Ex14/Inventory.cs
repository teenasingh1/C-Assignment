using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6Ex14
{
    public class Inventory
    {
        public Dictionary<string, Product> item = new Dictionary<string, Product>();
        public double value { get; set; }
        public Inventory()
        {
            this.value = 0;
        }
        public void AddProduct(string name, Product product)
        {
            this.item.Add(name, product);
            product.UpdateHandler += UpdateInventoryValue;
            this.value += product.Price * product.Quantity;
        }
        public void UpdateProduct(string name, float price)
        {
            Product product = this.item[name];
            product.Price = price;
        }
        public void UpdateProduct(string name, int quantity)
        {
            Product product = this.item[name];
            product.Quantity = quantity;
        }
        public Product RemoveProduct(string name)
        {
            Product remove = this.item[name];
            this.item.Remove(name);
            this.value -= remove.Price * remove.Quantity;
            return remove;
        }
        public void UpdateInventoryValue(object source, EventArgs e)
        {
            System.Console.WriteLine(" Inventory Value Handler ");
            System.Console.WriteLine(" Update Inventory Value ...");
            this.value = 0;
            foreach (KeyValuePair<string, Product> i in item)
            {
                this.value += i.Value.Price * i.Value.Quantity;
            }
            System.Console.WriteLine(" Value:: {0} ", this.value);
        }
    }
}