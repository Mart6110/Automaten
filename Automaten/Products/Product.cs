using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Products
{
    abstract class Product
    {
        // Properties
        private string name;
        private int price;
        private int id;

        // Encapsulations
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

        // Constructor
        public Product(string name, int price, int id)
        {
            this.name = name;
            this.price = price;
            this.id = id;
        }

        // Creating abstract method
        protected internal abstract void GetProduct(); 
    }
}
