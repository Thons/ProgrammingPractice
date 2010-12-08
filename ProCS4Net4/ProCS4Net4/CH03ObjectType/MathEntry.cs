using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH03ObjectType
{
    class MathEntry
    {
        static void Main(string[ ] args)
        {
            Console.WriteLine("圆周率是 " + MathLib.GetPi());
            int x = MathLib.GetSquareOf(5);
            Console.WriteLine("5的平方是 " + x);

            MathLib math = new MathLib();
            math.value = 30;
            Console.WriteLine("30的平方是 " + math.GetSquare());
        }
    }
}
