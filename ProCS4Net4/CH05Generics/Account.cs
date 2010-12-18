using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH05Generics
{
    public class Account : IAccount
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }

        public Account(string name, decimal balance)
        {
            this.Name = name;
            this.Balance = balance;
        }
    }
}
