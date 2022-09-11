using System;
using Automaten;

namespace Automaten
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating the object VendingMachine
            VendingMachine vendingMachine = new VendingMachine();

            // Calling the method run to start the vending machine
            vendingMachine.Run();
        }
    }
}
