using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Products
{
    class Drink : Product
    {
        // Properties
        private string drinkType;

        // Encapsulation
        public string DrinkType
        {
            get { return drinkType; }
        }

        // Constructor
        public Drink(string name, int price, int id, string drinkType) : base(name, price, id)
        {
            this.drinkType = drinkType;
        }

        // Override method to output the rooms interior
        protected internal override void GetProduct()
        {
            Console.WriteLine(Id + ". " + Name + " - " + Price + " kr.");
        }
    }
}
