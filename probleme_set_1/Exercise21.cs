using System;

namespace ProgrammingProblems_Set_1
{
    public class Exercise21
    {
        public static void GuessTheNumber()
        {
            Console.WriteLine("1 = YES \n0 = NO");
            guess(1, 1024, false);
            
        }

        private static void guess(int low, int high, bool success)
        {
            if (!success)
            {
                {
                    var currentGuess = (high + low) / 2;
                    if (guessRange(currentGuess))
                    {
                        if (guessNumber(currentGuess))
                        {
                            Console.WriteLine($"Your number is {currentGuess}");
                            guess(0, 0, true);
                        }
                        else
                        {
                            guess(currentGuess + 1, high, false);
                        }
                    }
                    else
                    {
                        guess(low, currentGuess- 1, false);
                    }
                }
            }
        }

        private static bool guessRange(int number)
        {
            Console.WriteLine($"is it >= {number} ?");
            var respone = int.Parse(Console.ReadLine());
            return respone == 1;
        }

        private static bool guessNumber(int number)
        {
            Console.WriteLine($"is it {number} ?");
            var respone = int.Parse(Console.ReadLine());
            return respone == 1;
        }
        
    }
}