using System;

namespace ProgrammingProblems_Set_1
{
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            ChooseProblem();
        }

        private static void ChooseProblem()
        {
            Console.WriteLine("Choose one problem:");

            var optionChosen = -1;
            while (optionChosen != 0)
            {
                optionChosen = GetUserInput();

                switch (optionChosen) 
                {
                    case -1:
                        Console.WriteLine("Wrong input. Try again...");
                        break;
                    case 1:
                        Exercise1.SolveFirstDegreeEquation();
                        break;
                    case 2:
                        Exercise2.SolveSecondDegreeEquation();
                        break;
                    case 3:
                        Exercise3.CanFirstInputBeDividedBySecond();
                        break;
                    case 4:
                        Exercise4.CheckLeapYear();
                        break;
                    case 5:
                        Exercise5.PrintNthNumber();
                        break;
                    case 6:
                        Exercise6.CanBeTriangle();
                        break;
                    case 7:
                        Exercise7.SwapTwoInputs();
                        break;
                    case 8:
                        Exercise8.SwapTwoInputsWithoutTempVar();
                        break;
                    case 9:
                        Exercise9.PrintAllDivisorOfInput();
                        break;
                    case 10:
                        Exercise10.CheckIfInputIsPrime();
                        break;
                    case 11:
                        Exercise11.PrintNumberInInverseOrder();
                        break;
                    case 12:
                        Exercise12.DivisibleCount();
                        break;
                    case 13:
                        Exercise13.LeapYearCount();
                        break;
                    case 14:
                        Exercise14.CheckPalindrome();
                        break;
                    case 15:
                        Exercise15.ThreeNumbersOrderly();
                        break;
                    case 16:
                        Exercise16.FiveNumbersOrderly();
                        break;
                    case 17:
                        Exercise17.Euclid();
                        break;
                    case 18:
                        Exercise18.Factorization();
                        break;
                    case 19:
                        Exercise19.FormedOf2Numbers();
                        break;
                    // TODO: Exercise 20 missing
                    case 21:
                        Exercise21.GuessTheNumber();
                        break;
                }
            }
        }
        
        private static int GetUserInput()
        {
            PromptTheUser();
            var userInput = Console.ReadLine();
            return ValidateInput(userInput);
        }
        
        private static int ValidateInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageUtils.AskingNumbersWithCountOf(1);
                return -1;
            }
            if (int.TryParse(input, out var optionChosen))
            {
                return optionChosen;
            }
            
            return -1;
        }
        
        private static void PromptTheUser()
        {
            Console.WriteLine("<------------------------------------------------------------------------->");
            Console.Write("\nIntroduce 1 for the first problem\n" +
                          "Introduce 2 for the second problem\n" +
                          "Introduce 3 for the third problem\n" +
                          "Introduce 4 for the fourth problem\n" +
                          "Introduce 5 for the fifth problem\n" +
                          "Introduce 6 for the sixth problem\n" +
                          "Introduce 7 for the seventh problem\n" +
                          "Introduce 8 for the eighth problem\n" +
                          "Introduce 9 for the ninth problem\n" +
                          "Introduce 10 for the tenth problem\n" +
                          "Introduce 11 for the eleventh problem\n" +
                          "Press 0 to quit!\n\n" +
                          "Choose one problem: ");
        }
        
    }
}