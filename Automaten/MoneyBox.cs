using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    class MoneyBox : VendingMachine
    {
        private int customerpayment;

        public int CustomerPayment { get => customerpayment; }

        public void Payment(int payment)
        {
            this.customerpayment = payment;
        }
    }
}
