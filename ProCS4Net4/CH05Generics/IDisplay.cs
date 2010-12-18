using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH05Generics
{
    public interface IDisplay<in T>
    {
        void Show(T item);
    }
}
