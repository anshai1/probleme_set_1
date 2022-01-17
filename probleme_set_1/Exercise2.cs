using System;

namespace ProgrammingProblems_Set_1
{
    public class Exercise2
    {
        
        public static void SolveSecondDegreeEquation()
        {
            Console.WriteLine(
                "Enter 3 numbers which will take the place of 'a', 'b' and 'c' from the equation: 'ax^2 + bx + c = 0'");
            
            MessageUtils.InputForVariableNamed("a");
            var a = Console.ReadLine();
            MessageUtils.InputForVariableNamed("b");
            var b = Console.ReadLine();
            MessageUtils.InputForVariableNamed("c");
            var c = Console.ReadLine();

            if (ValidationUtils.DoesContainWhiteSpaces(a, b, c))
            {
                MessageUtils.NoWhiteSpacesAllowed();
            }
            else if (int.TryParse(a, out var numberRepresentingA) && int.TryParse(b, out var numberRepresentingB) && int.TryParse(c, out var numberRepresentingC))
            {
                SolveSecondDegreeEquation(numberRepresentingA, numberRepresentingB, numberRepresentingC);
            }
            else
            {
                MessageUtils.AskingNumbersWithCountOf(3);
            }
        }

        private static void SolveSecondDegreeEquation(int numberRepresentingA, int numberRepresentingB, int numberRepresentingC)
        {
            if (numberRepresentingA == 0)
            {
                MessageUtils.CantDivideWithZero();
            }
            else
            {
                var delta = Math.Pow(numberRepresentingB, 2) - 4 * numberRepresentingA * numberRepresentingC;
                var x1 = (-numberRepresentingB + Math.Sqrt(Math.Abs(delta))) / (2 * numberRepresentingA);
                var x2 = (-numberRepresentingB - Math.Sqrt(Math.Abs(delta))) / (2 * numberRepresentingA);
                Console.WriteLine($"\nThe results are {x1} and {x2}");
            }
        }

    }
}