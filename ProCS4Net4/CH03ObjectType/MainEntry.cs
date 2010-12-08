using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH03ObjectType
{
    class MainEntry
    {
        public static readonly DateTime staticReadOnly;
        public readonly DateTime readOnly;

        static MainEntry()
        {
            staticReadOnly = DateTime.Now;
        }

        public MainEntry()
        {
            readOnly = DateTime.Now;
        }

        static void Main(string[ ] args)
        {
            Console.WriteLine("User Preferences: BackColor: " + UserPreference.BackColor.ToString());

            Money cash = new Money();
            cash.Amount = 100M;
            Console.WriteLine("cash.ToString() returns: " + cash.ToString());
            cash.AddToAmount(20M);
            Console.WriteLine("cash.ToString() returns: " + cash.ToString());
        }
    }
}
