using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH05Generics
{
    public class IntCalc:Calc<int>
    {
        public override int Add(int x, int y)
        {
            return x + y;
        }

        public override int Sub(int x, int y)
        {
            return x - y;
        }
    }
}
