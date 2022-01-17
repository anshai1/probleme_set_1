using System;

namespace ProgrammingProblems_Set_1
{
    public class Exercise11
    {

        public static void PrintNumberInInverseOrder()
        {

            Console.WriteLine("\nEnter a number to print it's inverse format:");
            MessageUtils.InputForVariableNamed("");
            var input = Console.ReadLine();
            
            if (ValidationUtils.DoesContainWhiteSpaces(input))
            {
                MessageUtils.NoWhiteSpacesAllowed();
            }
            else if (int.TryParse(input, out var numberRepresentingInput))
            {
                var result = 0;
                while (numberRepresentingInput != 0)
                {
                    result = result * 10 + numberRepresentingInput % 10;
                    numberRepresentingInput /= 10;
                }

                Console.WriteLine($"The inverse of your number is {result}");
            }
            else
            {
                MessageUtils.AskingNumbersWithCountOf(1);
            }
        }
        
    }
}