using System;

namespace ProgrammingProblems_Set_1
{
    public class Exercise3
    {

        public static void CanFirstInputBeDividedBySecond()
        {
            Console.WriteLine("Enter 2 numbers(namely n and k), to see if n can be divided by k...");
            
            MessageUtils.InputForVariableNamed("n");
            var n = Console.ReadLine();
            MessageUtils.InputForVariableNamed("k");
            var k = Console.ReadLine();
            
            if (ValidationUtils.DoesContainWhiteSpaces(n, k))
            {
                MessageUtils.NoWhiteSpacesAllowed();
            }
            else if (int.TryParse(n, out var numberRepresentingN) && int.TryParse(k, out var numberRepresentingK))
            {
                CanFirstInputBeDividedBySecond(numberRepresentingN, numberRepresentingK);
            }
            else
            {
                MessageUtils.AskingNumbersWithCountOf(2);
            }
        }

        private static void CanFirstInputBeDividedBySecond(int numberRepresentingN, int numberRepresentingK)
        {
            if (numberRepresentingK == 0)
            {
                MessageUtils.CantDivideWithZero();
            }
            else
            {
                string Message() => numberRepresentingN % numberRepresentingK == 0
                    ? $"\n{numberRepresentingN} can be divided by {numberRepresentingK} evenly"
                    : $"\n{numberRepresentingN} can not be divided by {numberRepresentingK} evenly";

                Console.WriteLine(Message());
            }
        }

    }
}