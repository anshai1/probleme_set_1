using System;

namespace ProgrammingProblems_Set_1
{
    public class Exercise6
    {

        public static void CanBeTriangle()
        {

            Console.WriteLine("Enter three numbers that will represent the side lengths: ");
            MessageUtils.InputForVariableNamed("first side length");
            var firstSide = Console.ReadLine();
            MessageUtils.InputForVariableNamed("second side length");
            var secondSide = Console.ReadLine();
            MessageUtils.InputForVariableNamed("third side length");
            var thirdSide = Console.ReadLine();
            
            if (ValidationUtils.DoesContainWhiteSpaces(firstSide) && ValidationUtils.DoesContainWhiteSpaces(secondSide) 
                                                                  && ValidationUtils.DoesContainWhiteSpaces(thirdSide))
            {
                MessageUtils.NoWhiteSpacesAllowed();
            }
            else if (int.TryParse(firstSide, out var numberRepresentingFirstSide) 
                     && int.TryParse(secondSide, out var numberRepresentingSecondSide) 
                     && int.TryParse(thirdSide, out var numberRepresentingThirdSide) )
            {
                PrintEvaluationResultOfTriangleSides(numberRepresentingFirstSide, numberRepresentingSecondSide, numberRepresentingThirdSide);
            }
            else
            {
                MessageUtils.AskingNumbersWithCountOf(3);
            }
            
        }

        private static void PrintEvaluationResultOfTriangleSides(int numberRepresentingFirstSide,
            int numberRepresentingSecondSide, int numberRepresentingThirdSide)
        {
            if (numberRepresentingFirstSide != 0 && numberRepresentingSecondSide != 0 && numberRepresentingThirdSide != 0
                && numberRepresentingFirstSide < numberRepresentingSecondSide + numberRepresentingThirdSide
                && numberRepresentingSecondSide < numberRepresentingFirstSide + numberRepresentingThirdSide
                && numberRepresentingThirdSide < numberRepresentingFirstSide + numberRepresentingSecondSide)
            {
                Console.WriteLine("Your input numbers can form a triangle.");
            }
            else
            {
                Console.WriteLine("Your input numbers can not form a triangle.");
            }
        }
        
        
    }
}