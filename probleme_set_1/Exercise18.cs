using System;

namespace ProgrammingProblems_Set_1
{
    public class Exercise18
    {
        public static void Factorization()
        {
            int a, b;
            Console.WriteLine("Please enter your integer: ");
            a = int.Parse(Console.ReadLine());

            for (b = 2; a > 1; b++)
                if (a % b == 0)
                {
                    int x = 0;
                    while (a % b == 0)
                    {
                        a /= b;
                        x++;
                    }
                    Console.Write($"{b}^{x} ");
                }
        }
    }
}