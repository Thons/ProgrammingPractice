using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH03ObjectType
{
    class ParameterTest
    {
        static void Main(string[ ] args)
        {
            //int i = 0;
            int[ ] ints = { 0, 1, 2, 3, 4, 5 };
            int i = 1;
            double x = 1.0;
            //int[ ] ints;

            //Console.WriteLine("i = " + i);
            Console.WriteLine("int[0] = " + ints[0]);
            Console.WriteLine("Calling SomeFunc");

            SomeFunc(ints, i);
            Console.WriteLine("i = " + i);
            Console.WriteLine("int[0] = " + ints[0]);

            Console.WriteLine(FullName(lastName: "Chang", firstName: "Thons"));

            Display(ref x);
            Console.WriteLine(x);
        }

        static void SomeFunc(int[ ] ints, int i)
        {
            ints[0] = 100;
            i = 100;
        }

        static string FullName(string firstName, string lastName, string country = "China")
        {
            return firstName + " " + lastName + " " + country;
        }

        static void Display(double x)
        {
            x = 50.0;
        }

        static void Display(ref double x)
        {
            x = 50.0;
        }
    }
}
