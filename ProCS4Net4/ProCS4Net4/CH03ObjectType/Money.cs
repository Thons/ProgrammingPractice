using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH03ObjectType
{
    class Money
    {
        private decimal amount;
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public override string ToString()
        {
            return "$" + Amount.ToString();
        }
    }
}
