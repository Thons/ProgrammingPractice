using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH03ObjectType
{
    static class MoneyExtension
    {
        public static void AddToAmount(this Money money, decimal amountToAdd)
        {
            money.Amount += amountToAdd;
        }
    }
}
