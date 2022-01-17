using System;

namespace ProgrammingProblems_Set_1
{
    public class Exercise4
    {
        public static void CheckLeapYear()
        {
            Console.WriteLine("Enter a number to check whether it is leap year or not: ");
            
            MessageUtils.InputForVariableNamed("year");
            var year = Console.ReadLine();
            
            if (ValidationUtils.DoesContainWhiteSpaces(year))
            {
                MessageUtils.NoWhiteSpacesAllowed();
            }
            else if (int.TryParse(year, out var numberRepresentingYear))
            {
                OutputOfIsLeapYearCheck(numberRepresentingYear, year);
            }
            else
            {
                MessageUtils.AskingNumbersWithCountOf(1);
            }
        }

        private static void OutputOfIsLeapYearCheck(int numberRepresentingYear, string year)
        {
            string Message() => numberRepresentingYear % 4 == 0 &&
                                (numberRepresentingYear % 100 != 0 || numberRepresentingYear % 400 == 0) ?
                $"\n{year} is a leap year" : $"\n{year} is not a leap year";

            Console.WriteLine(Message());
        }
        
    }
}