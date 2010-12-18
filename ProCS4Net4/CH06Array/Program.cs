using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CH06Array
{
    class Program
    {
        static void Main(string[ ] args)
        {
            int[ ] onedim = { 1, 2, 3 };
            int[,] twodim = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[, ,] threedim = { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } }, { { 9, 10 }, { 11, 12 } } };

            int[ ][ ] jagged = new int[3][ ];
            jagged[0] = new int[2] { 1, 2 };
            jagged[1] = new int[6] { 3, 4, 5, 6, 7, 8 };
            jagged[2] = new int[3] { 9, 10, 11 };

            Array intArr1 = Array.CreateInstance(typeof(int), 5);
            for (int i = 0; i < 5; i++)
            {
                intArr1.SetValue(12, i);
            }

            Console.WriteLine("这是一个{0}维数组。", threedim.Rank);
            for (int row = 0; row < jagged.Length; row++)
            {
                for (int element = 0; element < jagged[row].Length; element++)
                {
                    Console.WriteLine("锯齿数组：第{0}行，第{1}个元素，值为{2}", row + 1, element + 1, jagged[row][element]);
                }
            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(intArr1.GetValue(i));
            }

            Console.WriteLine();

            int[ ] intArr2 = (int[ ])intArr1;
            //int[ ] lengths = { 2, 3 };
            //int[ ] lowerBounds = { 1, 10 };
            Array racers = Array.CreateInstance(typeof(Person), 4);
            racers.SetValue(new Person { FirstName = "Thons", LastName = "Chang" }, 0);
            racers.SetValue(new Person { FirstName = "Leo", LastName = "Sans" }, 1);
            racers.SetValue(new Person { FirstName = "Thons2", LastName = "Chang" }, 2);
            racers.SetValue(new Person { FirstName = "Leo2", LastName = "Sans" }, 3);

            int[ ] intArr3 = { 1, 2 };
            int[ ] intArr4 = (int[ ])intArr3.Clone();

            Console.WriteLine(onedim[1]);
            Console.WriteLine(twodim[1, 1]);
            Console.WriteLine(threedim[1, 1, 1]);

            Console.WriteLine();

            //Array.Sort((Person[ ])(racers));
            Array.Sort((Person[ ])(racers), new PersonComparer(PersonCompareType.FirstName));
            //foreach (var item in racers)
            //{
            //    Console.WriteLine(item);
            //}

            int[ ] arr1 = { 1, 4, 5, 11, 13, 18 };
            int[ ] arr2 = { 3, 4, 5, 18, 21, 27, 33 };

            var segement = new ArraySegment<int>[2] { new ArraySegment<int>(arr1, 0, 3), new ArraySegment<int>(arr2, 3, 3) };
            var sum = SumOfSegments(segement);
            Console.WriteLine(sum);
            Console.WriteLine();
            var result = TupleSample.Divide(5, 2);
            Console.WriteLine("Result of division: {0}, reminder: {1}", result.Item1, result.Item2);

            var janet = new Person { FirstName = "Janet", LastName = "Jackson" };
            Person[ ] person1 = { new Person { FirstName = "Michael", LastName = "Jackson" }, janet };
            Person[ ] person2 = { new Person { FirstName = "Michael", LastName = "Jackson" }, janet };
            if (person1 != person2) Console.WriteLine("Not the same reference");
            if (!(person1 == person2)) Console.WriteLine("Not the same reference");

            var titles = new MusicTitles();
            foreach (var item in titles)
            {
                Console.WriteLine(item);
            }
            foreach (var item in titles.Reverse())
            {
                Console.WriteLine(item);
            }
            foreach (var item in titles.Subset(1, 2))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var game = new GameMoves();
            IEnumerator enumerator = game.Cross();
            while (enumerator.MoveNext())
            {
                enumerator = enumerator.Current as IEnumerator;
            }
        }

        static int SumOfSegments(ArraySegment<int>[ ] segements)
        {
            int sum = 0;
            foreach (var segment in segements)
            {
                for (int i = segment.Offset; i < segment.Offset + segment.Count; i++)
                {
                    sum += segment.Array[i];
                }
            }
            return sum;
        }
    }
}
