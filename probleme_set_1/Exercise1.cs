using System;

namespace ProgrammingProblems_Set_1
{
    public class Exercise1
    {
        public static void SolveFirstDegreeEquation()
        {
            Console.WriteLine(
                "Enter 2 numbers which will take the place of 'a' and 'b' from the equation 'ax + b = 0':");

            MessageUtils.InputForVariableNamed("a");
            var a = Console.ReadLine();
            MessageUtils.InputForVariableNamed("b");
            var b = Console.ReadLine();

            if (ValidationUtils.DoesContainWhiteSpaces(a, b))
            {
                MessageUtils.NoWhiteSpacesAllowed();
            }
            else if (int.TryParse(a, out var numberRepresentingA) && int.TryParse(b, out var numberRepresentingB))
            {
                SolveFirstDegreeEquation(numberRepresentingA, numberRepresentingB);
            }
            else
            {
                MessageUtils.AskingNumbersWithCountOf(2);
            }
        }

        private static void SolveFirstDegreeEquation(int numberRepresentingA, int numberRepresentingB)
        {
            if (numberRepresentingA == 0)
            {
                MessageUtils.CantDivideWithZero();
            }
            else
            {
                var result = -(numberRepresentingB / numberRepresentingA);
                Console.WriteLine("\nResult of the firstDegreeEquation is: " + result);
            }
        }
    }
}