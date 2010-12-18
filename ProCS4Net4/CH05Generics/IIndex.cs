using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH05Generics
{
    public interface IIndex<out T>
    {
        T this[int index] { get; }
        int Count { get; }
    }
}
