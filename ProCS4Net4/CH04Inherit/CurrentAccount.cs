using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH04Inherit
{
    class CurrentAccount : ITransferBankAccount
    {
        public bool TransferTo(IBankAccount destination, decimal amount)
        {
            bool result;
            result = Withdraw(amount);
            if (result)
                destination.PayIn(amount);
            return result;
        }

        private decimal balance;
        public void PayIn(decimal amount)
        {
            balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return true;
            }
            Console.WriteLine("余额不足！");
            return false;
        }

        public decimal Balance
        {
            get { return balance; }
        }

        public override string ToString()
        {
            return string.Format("Jupter Bank Account :{0,6:C}", balance);
        }
    }
}
