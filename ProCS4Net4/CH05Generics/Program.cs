using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CH05Generics
{
    class Program
    {
        static void Main(string[ ] args)
        {
            StaticDemo<string>.x = 4;
            StaticDemo<int>.x = 5;
            Console.WriteLine(StaticDemo<int>.x);

            Console.WriteLine();

            IIndex<Rectangle> rectangles = RectangleCollection.GetCollections();
            IIndex<Shape> shapes = rectangles;

            for (int i = 0; i < shapes.Count; i++)
            {
                Console.WriteLine(shapes[i]);
            }

            Console.WriteLine();

            IDisplay<Shape> shapeDisplay = new ShapeDisplay();
            IDisplay<Rectangle> rectangleDisplay = shapeDisplay;
            rectangleDisplay.Show(rectangles[0]);

            List<Account> accounts = new List<Account>()
            {
                new Account("Thons",100),
                new Account("Thons1",1100),
                new Account("Thons11",11100)
            };

            decimal amount = Accumulate(accounts);
            Console.WriteLine(amount);
        }

        static decimal Accumulate<TAccount>(IEnumerable<TAccount> source)
            where TAccount : IAccount
        {
            decimal sum = 0;
            foreach (TAccount a in source)
            {
                sum += a.Balance;
            }
            return sum;
        }
    }
}
