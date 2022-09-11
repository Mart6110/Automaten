using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Products
{
    class Candy : Product
    {
        // Properties
        private string candyType;

        // Encapsulation
        public string CandyType
        {
            get { return candyType; }
        }

        // Constructor
        public Candy(string name, int price, int id, string candyType) : base(name, price, id)
        {
            this.candyType = candyType;
        }

        // Override method to output the rooms interior
        protected internal override void GetProduct()
        {
            Console.WriteLine(Id + ". " + Name + " - " + Price + " kr.");
        }
    }
}
