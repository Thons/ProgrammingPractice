using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH06Array
{
    public static class TupleSample
    {
        public static Tuple<int, int> Divide(int dividend, int divisor)
        {
            int result = dividend / divisor;
            int reminder = dividend / divisor;

            return Tuple.Create<int, int>(result, reminder);
        }
    }
}
