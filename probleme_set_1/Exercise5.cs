using System;

namespace ProgrammingProblems_Set_1
{
    public class Exercise5
    {
        
        public static void PrintNthNumber()
        {
            Console.WriteLine(
                "Enter first a number, then second the nth number you want to extract from it(the count will start from the end of the number):"
                );
            
            MessageUtils.InputForVariableNamed("that will be extracted from");
            var numberToExtractFrom = Console.ReadLine();
            MessageUtils.InputForVariableNamed("nth number");
            var nthNumber = Console.ReadLine();
            
            if (ValidationUtils.DoesContainWhiteSpaces(numberToExtractFrom) && ValidationUtils.DoesContainWhiteSpaces(nthNumber))
            {
                MessageUtils.NoWhiteSpacesAllowed();
            }
            else if (int.TryParse(numberToExtractFrom, out var parsedNumberToExtractFrom) && int.TryParse(nthNumber, out var numberRepresentingNthNumber))
            {
                PrintNthNumber(numberRepresentingNthNumber, parsedNumberToExtractFrom);
            }
            else
            {
                MessageUtils.AskingNumbersWithCountOf(2);
            }
            
        }

        private static void PrintNthNumber(int numberRepresentingNthNumber, int parsedNumberToExtractFrom)
        {
            var result = 0;
            for (var i = 0; i < numberRepresentingNthNumber; i++)
            {
                result = parsedNumberToExtractFrom % 10;
                parsedNumberToExtractFrom /= 10;
            }

            Console.WriteLine($"Your chosen number is: {result}");
        }
        
        
    }
}