using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH03ObjectType
{
    class MathLib
    {
        public int value;

        public int GetSquare()
        {
            return value * value;
        }

        public static int GetSquareOf(int x)
        {
            return x * x;
        }

        public static double GetPi()
        {
            return 3.14159265;
        }
    }
}
