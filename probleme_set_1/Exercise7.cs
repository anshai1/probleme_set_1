using System;

namespace ProgrammingProblems_Set_1
{
    public class Exercise7
    {

        public static void SwapTwoInputs()
        {
            Console.WriteLine("Enter 2 numbers, that will be swapped:");
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
                var tempVar = a;
                a = b;
                b = tempVar;

                Console.WriteLine($"After swap a = {a} and b = {b}...");
            }
            else
            {
                MessageUtils.AskingNumbersWithCountOf(2);
            }
            
        }
        
    }
}