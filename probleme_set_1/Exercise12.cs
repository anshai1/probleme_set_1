using System;

namespace ProgrammingProblems_Set_1
{
    public class Exercise12
    {

        public static void DivisibleCount()
        {
            int lowerBound;
            int upperBound;
            int divider;
            int divideCount = 0;

            Console.WriteLine("Enter the value for the lower bound");
            lowerBound = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the value for the upper bound");
            upperBound = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the value for the divider");
            divider = int.Parse(Console.ReadLine());

            for (int i = lowerBound; i <= upperBound; i++)
            {
                if (i % divider == 0)
                {
                    divideCount++;
                }
            }
            
            Console.WriteLine($"There are {divideCount} numbers divisible by {divider}");
        }
    }
}