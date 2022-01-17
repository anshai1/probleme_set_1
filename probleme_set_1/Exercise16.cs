using System;

namespace ProgrammingProblems_Set_1
{
    public class Exercise16
    {
        public static void FiveNumbersOrderly()
        {
            Console.WriteLine("Enter five numbers separated by a newline");
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var d = int.Parse(Console.ReadLine());
            var e = int.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                if (a > b)
                {
                    (a, b) = (b, a);
                }

                if (b > c)
                {
                    (b, c) = (c, b);
                }

                if (c > d)
                {
                    (c, d) = (d, c);
                }

                if (d > e)
                {
                    (d, e) = (e, d);
                }
            }

            Console.WriteLine($"{a} - {b} - {c} - {d} - {e}");
        }
    }
}