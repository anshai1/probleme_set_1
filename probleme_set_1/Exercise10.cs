using System;

namespace ProgrammingProblems_Set_1
{
    public class Exercise10
    {

        public static void CheckIfInputIsPrime()
        {
            Console.WriteLine("\nEnter a number to verify if it's prime:");
            
            MessageUtils.InputForVariableNamed("");
            var input = Console.ReadLine();
            
            if (ValidationUtils.DoesContainWhiteSpaces(input))
            {
                MessageUtils.NoWhiteSpacesAllowed();
            }
            else if (int.TryParse(input, out var numberRepresentingInput))
            {
                string Message() => IsPrime(numberRepresentingInput)
                    ? $"\n{numberRepresentingInput} is prime"
                    : $"\n{numberRepresentingInput} is not prime";

                Console.WriteLine(Message());
            }
            else
            {
                MessageUtils.AskingNumbersWithCountOf(1);
            }
        }

        private static bool IsPrime(int numberRepresentingInput)
        {
            for (var i = 2; i <= numberRepresentingInput / 2; i++)
            {
                if (numberRepresentingInput % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        
        
    }
}