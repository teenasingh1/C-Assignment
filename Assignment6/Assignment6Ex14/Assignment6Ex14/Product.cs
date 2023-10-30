using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6Ex14
{
    public class Product : IEquatable<Product>
    {
        public int id { get; }
        private float price;
        private int quantity;
        public float Price { get { return price; } set { price = value; OnPriceQuantityUpdate(); } }
        public int Quantity { get { return quantity; } set { quantity = value; OnPriceQuantityUpdate(); } }
        public delegate void PriceQuantityUpdateHandler(object source, EventArgs e);
        public event PriceQuantityUpdateHandler UpdateHandler;
        public Product(int id)
        {
            this.id = id;
        }
        public Product(int id, float price) : this(id)
        {
            this.price = price;
        }
        public Product(int id, float price, int quantity) : this(id, price)
        {
            this.quantity = quantity;
        }
        public bool Equals(Product other)
        {
            if (other == null || other.id != this.id) return false;
            return true;
        }
        protected virtual void OnPriceQuantityUpdate()
        {
            if (UpdateHandler != null)
            {
                UpdateHandler(this, EventArgs.Empty);
            }
        }
    }
}
