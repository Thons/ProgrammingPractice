using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH02CoreCSharp
{
    class ConsoleIO
    {
        static void Main(string[ ] args)
        {
            int i = 940;
            int j = 73;
            Console.WriteLine(" {0,4}\n+{1,4}\n ----\n {2,4}", i, j, i + j);

            Console.WriteLine();

            decimal m = 940.23M;
            decimal n = 73.7M;
            Console.WriteLine(" {0,9:C2}\n+{1,9:C2}\n ------------ \n {2,9:C2}", m, n, m + n);

            Console.ReadLine();
        }
    }
}
