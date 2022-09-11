using System;
using Automaten;

namespace Automaten
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine();

            vendingMachine.Run();
        }
    }
}
