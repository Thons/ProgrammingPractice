using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH05Generics
{
    public interface IAccount
    {
        decimal Balance { get; }
        string Name { get; }
    }
}
