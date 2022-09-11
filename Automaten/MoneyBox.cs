using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    class MoneyBox : VendingMachine
    {
        // Properties
        private int customerpayment;
        private int money = 500;

        // Encapsulation
        public int CustomerPayment { get => customerpayment; }
        public int Money { get => money; }

        // A method to hold costumers payment while the costumer choose the item the want
        public void Payment(int payment)
        {
            this.customerpayment = payment;
        }

        // A method that add the payment to the earnings
        public void TotalMoney(int money)
        {
            this.money += money;
        }

        // A mothod that let the admin take out money from the machine
        public void TakeMoney(int money)
        {
            this.money -= money;
        }

        // A method that let the admin insert money into the machine
        public void InsertMoney(int money)
        {
            this.money += money;
        }
    }
}
