using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Products
{
    abstract class Product
    {
        private string name;
        private int price;
        private int id;

        public string Name 
        { 
            get { return name; }
            set { name = value; }
        }
        public int Price
        { 
            get { return price; }
            set { price = value; }
        }
        public int Id
        {
            get { return id; }
        }

        public Product(string name, int price, int id)
        {
            this.name = name;
            this.price = price;
            this.id = id;
        }

        protected internal abstract void GetProduct(); 
    }
}
