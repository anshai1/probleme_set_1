using System;

namespace ProgrammingProblems_Set_1
{
    public class Exercise8
    {

        public static void SwapTwoInputsWithoutTempVar()
        {
            Console.WriteLine("Enter 2 numbers, that will be swapped without temporary variables:");
            MessageUtils.InputForVariableNamed("a");
            var a = Console.ReadLine();
            MessageUtils.InputForVariableNamed("b");
            var b = Console.ReadLine();
            
            if (ValidationUtils.DoesContainWhiteSpaces(a) && ValidationUtils.DoesContainWhiteSpaces(b))
            {
                MessageUtils.NoWhiteSpacesAllowed();
            }
            else if (int.TryParse(a, out var numberRepresentingA) && int.TryParse(b, out var numberRepresentingB))
            {
                numberRepresentingA = numberRepresentingA + numberRepresentingB;
                numberRepresentingB = numberRepresentingA - numberRepresentingB;
                numberRepresentingA = numberRepresentingA - numberRepresentingB;

                Console.WriteLine($"After swap a = {numberRepresentingA} and b = {numberRepresentingB}...");
            }
            else
            {
                MessageUtils.AskingNumbersWithCountOf(2);
            }
            
        }
        
    }
}