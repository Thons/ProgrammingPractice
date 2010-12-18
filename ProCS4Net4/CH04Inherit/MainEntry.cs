using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH04Inherit
{
    class MainEntry
    {
        static void Main(string[ ] args)
        {
            IBankAccount venusAccount = new SaverAccount();
            ITransferBankAccount jupterAccount = new CurrentAccount();
            venusAccount.PayIn(200);
            Console.WriteLine(venusAccount.ToString());
            venusAccount.Withdraw(300);
            Console.WriteLine(venusAccount.ToString());
            jupterAccount.PayIn(500);
            jupterAccount.TransferTo(venusAccount, 100);
            Console.WriteLine(venusAccount.ToString());
            Console.WriteLine(jupterAccount.ToString());
        }
    }
}
