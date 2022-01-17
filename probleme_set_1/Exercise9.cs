using System;

namespace ProgrammingProblems_Set_1
{
    public class Exercise9
    {

        public static void PrintAllDivisorOfInput()
        {

            Console.WriteLine("Enter a number to see it's divisors:");
            MessageUtils.InputForVariableNamed("");
            var input = Console.ReadLine();
            
            if (ValidationUtils.DoesContainWhiteSpaces(input))
            {
                MessageUtils.NoWhiteSpacesAllowed();
            }
            else if (int.TryParse(input, out var numberRepresentingInput))
            {
                Console.WriteLine($"\nDivisors of {input} are: ");
                for (int i = 1; i < numberRepresentingInput; i++)
                {
                    if (numberRepresentingInput % i == 0)
                    {
                        Console.Write(i + "  ");
                    }
                }

                Console.WriteLine();
            }
            else
            {
                MessageUtils.AskingNumbersWithCountOf(1);
            }
            
        }
        
    }
}