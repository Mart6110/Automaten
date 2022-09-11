using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Products
{
    class Drink : Product
    {
        private string drinkType;

        public string DrinkType
        {
            get { return drinkType; }
        }

        public Drink(string name, int price, int id, string drinkType) : base(name, price, id)
        {
            this.drinkType = drinkType;
        }

        protected internal override void GetProduct()
        {
            Console.WriteLine(Id + ". " + Name + " - " + Price + " kr.");
        }
    }
}
