using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Automaten;
using Automaten.Products;

namespace UI
{
    class Gui
    {
        private ConsoleKeyInfo choice;

        MoneyBox payment = new MoneyBox();
        VendingMachine vendingMachine = new VendingMachine();
        public void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("-------- Vending Machine --------");
            Console.WriteLine("---------------------------------");
            Console.WriteLine();

            Console.WriteLine("----------- Products ------------");
            Console.WriteLine();
            vendingMachine.Product();
            Console.WriteLine();

            Console.WriteLine("-------- Insert Money ---------");
            payment.Payment(Convert.ToInt32(Console.ReadLine()));
            BuyingMenu();

        }
        public void BuyingMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("-------- Vending Machine --------");
            Console.WriteLine("---------------------------------");
            Console.WriteLine();

            Console.WriteLine("-------- Inserted Money ---------");
            Console.WriteLine();
            Console.WriteLine(payment.CustomerPayment + " kr.");
            Console.WriteLine();

            Console.WriteLine("----------- Products ------------");
            Console.WriteLine();
            vendingMachine.Product();
            Console.WriteLine();
        }
        public void OptionMenu()
        {
            Console.WriteLine("----------- Option Menu ------------");
            // To get to the admin page I've added an option to get there. Normally we would not give our customers the option to select the admin page.
            Console.WriteLine("1. Admin page");
            Console.WriteLine("2. Customer page");

            choice = Console.ReadKey();

            switch (choice.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();

                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Menu();
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Please insert one of the two options");
                    Thread.Sleep(2000);
                    Console.Clear();
                    break;
            }
        }
        public void AdminMenu()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("----- Vending Machine Admin -----");
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            Console.WriteLine("1. Fill storage");
            Console.WriteLine("2. Take earnings");
            Console.WriteLine("3. Change product price");
            // So I can go back to the start
            Console.WriteLine("4. Go back to Option menu");
        }
    }
}
