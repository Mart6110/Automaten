using Automaten.Products;
using UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    class VendingMachine
    {
        bool exit = false;

        Product cocacola = new Drink("Coca Cola", 20, 1, "Soda");
        Product pepsi = new Drink("Pepsi", 20, 2, "Soda");
        Product faxekondi = new Drink("Faxe Kondi", 20, 3, "Soda");
        Product snickers = new Candy("Snickers", 10, 4, "Chocolate bar");
        Product twix = new Candy("Twix", 10, 5, "Chocolate bar");
        Product marsbar = new Candy("Mars bar", 10, 6, "Chocolate bar");

        public void Product()
        {
            List<Product> products = new List<Product>();

            products.Add(cocacola);
            products.Add(pepsi);
            products.Add(faxekondi);
            products.Add(snickers);
            products.Add(twix);
            products.Add(marsbar);

            foreach(Product product in products)
            {
                product.GetProduct();
            }
        }

        public void Run()
        {
            do
            {
                Gui gui = new Gui();
                gui.OptionMenu();
            } while (exit != false);
        }
    }
}
