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
        // Properties
        private int numberOfCocacola = 20;
        private int numberOfPepsi = 20;
        private int numberOfFaxekondi = 20;
        private int numberOfSnickers = 20;
        private int numberOfTwix = 20;
        private int numberOfMarsbar = 20;
        bool exit = false;

        Product cocacola = new Drink("Coca Cola", 20, 1, "Soda");
        Product pepsi = new Drink("Pepsi", 20, 2, "Soda");
        Product faxekondi = new Drink("Faxe Kondi", 20, 3, "Soda");
        Product snickers = new Candy("Snickers", 10, 4, "Chocolate bar");
        Product twix = new Candy("Twix", 10, 5, "Chocolate bar");
        Product marsbar = new Candy("Mars bar", 10, 6, "Chocolate bar");

        // Encapsulation
        public int NumberOfCocacola { get => numberOfCocacola; set => numberOfCocacola = value; }
        public int NumberOfPepsi { get => numberOfPepsi; set => numberOfPepsi = value; }
        public int NumberOfFaxekondi { get => numberOfFaxekondi; set => numberOfFaxekondi = value; }
        public int NumberOfSnickers { get => numberOfSnickers; set => numberOfSnickers = value; }
        public int NumberOfTwix { get => numberOfTwix; set => numberOfTwix = value; }
        public int NumberOfMarsbar { get => numberOfMarsbar; set => numberOfMarsbar = value; }

        // A method to that create a list and add the items to it and displays all item in the list
        public void Product()
        {
            // A list that holds all the products in the machine
            List<Product> products = new List<Product>();
            products.Add(cocacola);
            products.Add(pepsi);
            products.Add(faxekondi);
            products.Add(snickers);
            products.Add(twix);
            products.Add(marsbar);

            // A foreach that loops through each product in the list and display it
            foreach(Product product in products)
            {
                product.GetProduct();
            }
        }

        // Staring the machine
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
