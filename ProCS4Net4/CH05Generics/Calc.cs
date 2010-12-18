using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH05Generics
{
    public abstract class Calc<T>
    {
        public abstract T Add(T x, T y);
        public abstract T Sub(T x, T y);
    }
}
