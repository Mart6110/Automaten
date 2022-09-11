using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten.Products
{
    class Candy : Product
    {
        private string candyType;

        public string CandyType
        {
            get { return candyType; }
        }

        public Candy(string name, int price, int id, string candyType) : base(name, price, id)
        {
            this.candyType = candyType;
        }

        protected internal override void GetProduct()
        {
            Console.WriteLine(Id + ". " + Name + " - " + Price + " kr.");
        }
    }
}
