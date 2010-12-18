using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH04Inherit
{
    public class GoldAccount : IBankAccount
    {
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
            return String.Format("Jupter Bank Saver: 余额为：{0,6:C}", balance);
        }
    }
}
