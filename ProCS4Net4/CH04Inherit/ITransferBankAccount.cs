using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH04Inherit
{
    interface ITransferBankAccount:IBankAccount
    {
        bool TransferTo(IBankAccount destination, decimal amount);
    }
}
