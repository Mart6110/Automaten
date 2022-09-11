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

        // Creating objects
        MoneyBox payment = new MoneyBox();
        VendingMachine vendingMachine = new VendingMachine();

        // Gui for costumer
        public void Menu()
        {
            Console.Clear();
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

        // Gui for Buying menu
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
            Console.WriteLine("7. Get money back");
            Console.WriteLine();
            Console.WriteLine("---- Please Choice A Product ----");
            choice = Console.ReadKey();

            switch (choice.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    if (vendingMachine.NumberOfCocacola > 0) // If there are more then 0 mars bar
                    {
                        if (payment.CustomerPayment < 20) // Checking if there is enough money
                        {
                            Console.WriteLine("You need more money to buy this.");
                            Thread.Sleep(2000);
                            BuyingMenu();
                        }
                        else
                        {
                            if (payment.CustomerPayment == 20) // If costumer pays exact amount of money
                            {
                                payment.TotalMoney(20);
                                payment.Payment(0);
                                vendingMachine.NumberOfCocacola = -1;
                                Console.WriteLine("Coca Cola");
                                Console.WriteLine("No money in return");
                                Thread.Sleep(2000);
                            }
                            else // If costumer pays more then the user will also get money back
                            {
                                payment.Payment(payment.CustomerPayment - 20);
                                payment.TotalMoney(20);
                                vendingMachine.NumberOfCocacola = -1;
                                Console.WriteLine("Coca Cola");
                                Console.WriteLine("Money back: " + payment.CustomerPayment + " kr.");
                                payment.Payment(0);
                                Thread.Sleep(2000);
                            }
                            Menu();
                        }
                    }
                    else // If no more of that item is left
                    {
                        Console.WriteLine("No Coca Cola left");
                        Thread.Sleep(2000);
                        BuyingMenu();
                    }
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    if (vendingMachine.NumberOfPepsi > 0) // If there are more then 0 mars bar
                    {
                        if (payment.CustomerPayment < 20) // Checking if there is enough money
                        {
                            Console.WriteLine("You need more money to buy this.");
                            Thread.Sleep(2000);
                            BuyingMenu();
                        }
                        else
                        {
                            if (payment.CustomerPayment == 20) // If costumer pays exact amount of money
                            {
                                payment.TotalMoney(20);
                                payment.Payment(0);
                                vendingMachine.NumberOfPepsi = -1;
                                Console.WriteLine("Pepsi");
                                Console.WriteLine("No money in return");
                                Thread.Sleep(2000);
                            }
                            else // If costumer pays more then the user will also get money back
                            {
                                payment.Payment(payment.CustomerPayment - 20);
                                payment.TotalMoney(20);
                                vendingMachine.NumberOfPepsi = -1;
                                Console.WriteLine("Pepsi");
                                Console.WriteLine("Money back: " + payment.CustomerPayment + " kr.");
                                payment.Payment(0);
                                Thread.Sleep(2000);
                            }
                            Menu();
                        }
                    }
                    else // If no more of that item is left
                    {
                        Console.WriteLine("No Pepsi left");
                        Thread.Sleep(2000);
                        BuyingMenu();
                    }
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    if (vendingMachine.NumberOfFaxekondi > 0) // If there are more then 0 mars bar
                    {
                        if (payment.CustomerPayment < 20) // Checking if there is enough money
                        {
                            Console.WriteLine("You need more money to buy this.");
                            Thread.Sleep(2000);
                            BuyingMenu();
                        }
                        else
                        {
                            if (payment.CustomerPayment == 20) // If costumer pays exact amount of money
                            {
                                payment.TotalMoney(20);
                                payment.Payment(0);
                                vendingMachine.NumberOfFaxekondi = -1;
                                Console.WriteLine("Faxe Kondi");
                                Console.WriteLine("No money in return");
                                Thread.Sleep(2000);
                            }
                            else // If costumer pays more then the user will also get money back
                            {
                                payment.Payment(payment.CustomerPayment - 20);
                                payment.TotalMoney(20);
                                vendingMachine.NumberOfFaxekondi = -1;
                                Console.WriteLine("Faxe Kondi");
                                Console.WriteLine("Money back: " + payment.CustomerPayment + " kr.");
                                payment.Payment(0);
                                Thread.Sleep(2000);
                            }
                            Menu();
                        }
                    }
                    else // If no more of that item is left
                    {
                        Console.WriteLine("No Faxe Kondi left");
                        Thread.Sleep(2000);
                        BuyingMenu();
                    }
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    if (vendingMachine.NumberOfSnickers > 0) // If there are more then 0 mars bar
                    {
                        if (payment.CustomerPayment < 10) // Checking if there is enough money
                        {
                            Console.WriteLine("You need more money to buy this.");
                            Thread.Sleep(2000);
                            BuyingMenu();
                        }
                        else
                        {
                            if (payment.CustomerPayment == 10) // If costumer pays exact amount of money
                            {
                                payment.TotalMoney(10);
                                payment.Payment(0);
                                vendingMachine.NumberOfSnickers = -1;
                                Console.WriteLine("Snickers");
                                Console.WriteLine("No money in return");
                                Thread.Sleep(2000);
                            }
                            else // If costumer pays more then the user will also get money back
                            {
                                payment.Payment(payment.CustomerPayment - 10);
                                payment.TotalMoney(10);
                                vendingMachine.NumberOfSnickers = -1;
                                Console.WriteLine("Snickers");
                                Console.WriteLine("Money back: " + payment.CustomerPayment + " kr.");
                                payment.Payment(0);
                                Thread.Sleep(2000);
                            }
                            Menu();
                        }
                    }
                    else // If no more of that item is left
                    {
                        Console.WriteLine("No Snickers left");
                        Thread.Sleep(2000);
                        BuyingMenu();
                    }
                    break;
                case ConsoleKey.D5:
                    Console.Clear();
                    if (vendingMachine.NumberOfTwix > 0) // If there are more then 0 mars bar
                    {
                        if (payment.CustomerPayment < 10) // Checking if there is enough money
                        {
                            Console.WriteLine("You need more money to buy this.");
                            Thread.Sleep(2000);
                            BuyingMenu();
                        }
                        else
                        {
                            if (payment.CustomerPayment == 10) // If costumer pays exact amount of money
                            {
                                payment.TotalMoney(10);
                                payment.Payment(0);
                                vendingMachine.NumberOfTwix =- 1;
                                Console.WriteLine("Twix");
                                Console.WriteLine("No money in return");
                                Thread.Sleep(2000);
                            }
                            else // If costumer pays more then the user will also get money back
                            {
                                payment.Payment(payment.CustomerPayment - 10);
                                payment.TotalMoney(10);
                                vendingMachine.NumberOfTwix =- 1;
                                Console.WriteLine("Twix");
                                Console.WriteLine("Money back: " + payment.CustomerPayment + " kr.");
                                payment.Payment(0);
                                Thread.Sleep(2000);
                            }
                            Menu();
                        }
                    }
                    else // If no more of that item is left
                    {
                        Console.WriteLine("No Twix left");
                        Thread.Sleep(2000);
                        BuyingMenu();
                    }
                    break;
                case ConsoleKey.D6:
                    Console.Clear();
                    if(vendingMachine.NumberOfMarsbar > 0) // If there are more then 0 mars bar
                    {
                        if (payment.CustomerPayment < 10) // Checking if there is enough money
                        {
                            Console.WriteLine("You need more money to buy this.");
                            Thread.Sleep(2000);
                            BuyingMenu();
                        }
                        else
                        {
                            if (payment.CustomerPayment == 10) // If costumer pays exact amount of money
                            {
                                payment.TotalMoney(10);
                                payment.Payment(0);
                                vendingMachine.NumberOfMarsbar =- 1;
                                Console.WriteLine("Mars bar");
                                Console.WriteLine("No money in return");
                                Thread.Sleep(2000);
                            }
                            else // If costumer pays more then the user will also get money back
                            {
                                payment.Payment(payment.CustomerPayment - 10);
                                payment.TotalMoney(10);
                                vendingMachine.NumberOfMarsbar =- 1;
                                Console.WriteLine("Mars bar");
                                Console.WriteLine("Money back: " + payment.CustomerPayment + " kr.");
                                payment.Payment(0);
                                Thread.Sleep(2000);
                            }
                            Menu();
                        }
                    }
                    else // If no more of that item is left
                    {
                        Console.WriteLine("No Mars bar left");
                        Thread.Sleep(2000);
                        BuyingMenu();
                    }
                    break;
                // If the costumer dont want to get anything, return the money to the costumer
                case ConsoleKey.D7:
                    Console.Clear();
                    Console.WriteLine("Getting " + payment.CustomerPayment + " kr. back");
                    payment.Payment(0);
                    Thread.Sleep(2000);
                    Menu();
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("No Item has that number");
                    Thread.Sleep(2000);
                    Console.Clear();
                    BuyingMenu();
                    break;
            }
        }
        public void OptionMenu()
        {
            Console.WriteLine("----------- Option Menu ------------");
            // To get to the admin page I've added an option to get there. Normally we would not give our customers the option to select the admin page.
            Console.WriteLine("1. Admin page");
            Console.WriteLine("2. Customer page");

            choice = Console.ReadKey();

            // A switch so I can go into either admin menu or customer menu
            switch (choice.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    AdminMenu();
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
                    OptionMenu();
                    break;
            }
        }
        public void AdminMenu()
        {
            // Gui for Admin menu
            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("----- Vending Machine Admin -----");
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            Console.WriteLine("1. Fill storage");
            Console.WriteLine("2. Earnings");
            // So I can go back to the start
            Console.WriteLine("3. Go back to Option menu");
            choice = Console.ReadKey();

            // A switch that gives the option to go into the Storage, Earnings, and Option menus
            switch (choice.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    StorageMenu();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    EarningMenu();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    OptionMenu();
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Please insert one of the three options");
                    Thread.Sleep(2000);
                    Console.Clear();
                    AdminMenu();
                    break;
            }
        }

        public void StorageMenu()
        {
            int addMore;

            // Gui for Storage menu
            Console.WriteLine("---------------------------------");
            Console.WriteLine("----- Vending Machine Admin -----");
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            Console.WriteLine("------------ Storage ------------");
            Console.WriteLine();
            Console.WriteLine("1. Coca Cola - " + vendingMachine.NumberOfCocacola);
            Console.WriteLine("2. Pepsi - " + vendingMachine.NumberOfPepsi);
            Console.WriteLine("3. Faxe Kondi - " + vendingMachine.NumberOfFaxekondi);
            Console.WriteLine("4. Snickers - " + vendingMachine.NumberOfSnickers);
            Console.WriteLine("5. Twix - " + vendingMachine.NumberOfTwix);
            Console.WriteLine("6. Mars bar - " + vendingMachine.NumberOfMarsbar);
            Console.WriteLine("7. Return to admin page");
            Console.WriteLine();
            Console.WriteLine("Select an itemInsert the number you want to add and select an item");
            addMore = Convert.ToInt32(Console.ReadLine());
            choice = Console.ReadKey();

            // A swith that give the option refill the vending machine
            switch (choice.Key)
            {
                case ConsoleKey.D1:
                    vendingMachine.NumberOfCocacola += addMore;
                    Console.Clear();
                    StorageMenu();
                    break;
                case ConsoleKey.D2:
                    vendingMachine.NumberOfPepsi += addMore;
                    Console.Clear();
                    StorageMenu();
                    break;
                case ConsoleKey.D3:
                    vendingMachine.NumberOfFaxekondi += addMore;
                    Console.Clear();
                    StorageMenu();
                    break;
                case ConsoleKey.D4:
                    vendingMachine.NumberOfSnickers += addMore;
                    Console.Clear();
                    StorageMenu();
                    break;
                case ConsoleKey.D5:
                    vendingMachine.NumberOfTwix += addMore;
                    Console.Clear();
                    StorageMenu();
                    break;
                case ConsoleKey.D6:
                    vendingMachine.NumberOfMarsbar += addMore;
                    Console.Clear();
                    StorageMenu();
                    break;
                case ConsoleKey.D7: // Return to admin menu
                    Console.Clear();
                    AdminMenu();
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Please insert one of the seven options");
                    Thread.Sleep(2000);
                    Console.Clear();
                    StorageMenu();
                    break;
            }
        }

        public void EarningMenu()
        {
            // Gui for Earning menu
            Console.WriteLine("---------------------------------");
            Console.WriteLine("----- Vending Machine Admin -----");
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            Console.WriteLine("------------ Earning ------------");
            Console.WriteLine();
            Console.WriteLine("Money: " + payment.Money);
            Console.WriteLine();
            Console.WriteLine("1. Take money");
            Console.WriteLine("2. Insert money");
            Console.WriteLine("3. Return");

            choice = Console.ReadKey();
            Console.WriteLine();

            // A Switch that gives the option to take or insert money in the vending machine
            switch (choice.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("Insert number you want to take");
                    // Taking money out off the vending machine
                    payment.TakeMoney(Convert.ToInt32(Console.ReadLine()));
                    Console.Clear();
                    EarningMenu();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("Insert number you want to set in");
                    // Inserting money into the vending machine
                    payment.InsertMoney(Convert.ToInt32(Console.ReadLine()));
                    Console.Clear();
                    EarningMenu();
                    break;
                case ConsoleKey.D3: // Return to admin menu
                    Console.Clear();
                    AdminMenu();
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Please insert one of the three options");
                    Thread.Sleep(2000);
                    Console.Clear();
                    EarningMenu();
                    break;
            }
        }
    }
}
