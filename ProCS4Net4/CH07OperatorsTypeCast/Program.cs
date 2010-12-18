using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH07OperatorsTypeCast
{
    class Program
    {
        static void Main(string[ ] args)
        {
            int? int1 = null;
            int int2 = int1 ?? 20;
            Console.WriteLine(int2);
            Vector vect1 = new Vector(1, 2, 3);
            Vector vect2 = new Vector(4, 5, 6);
            Console.WriteLine(vect1 + vect2);
            Console.ReadLine();
        }
    }
}
