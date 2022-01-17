using System;

namespace ProgrammingProblems_Set_1
{
    public class Exercise13
    {
        public static void LeapYearCount()
        {
            int lowerBound;
            int upperBound;

            Console .WriteLine("Enter the value for the lower bound");
            lowerBound = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the value for the upper bound");
            upperBound = int.Parse(Console.ReadLine());
            
            int leapYearCount = 0;
            for (int year = lowerBound; year < upperBound; year++)
            {
                if (isLeapYear(year))
                {
                    leapYearCount++;
                }
            }
            
            Console.WriteLine($"There are {leapYearCount} leap year(s) between {lowerBound} - {upperBound}");
        }

        private static bool isLeapYear(int year)
        {
            return year % 4 == 0 && (year % 100 == 0 || year % 400 == 0);
        }
    }
}