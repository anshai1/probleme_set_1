using System;

namespace ProgrammingProblems_Set_1
{
    public class Exercise14
    {
        public static void CheckPalindrome()
        {   
            Console.WriteLine("Enter a number to check whether it is palindrome or not");
            var numToCheck = int.Parse(Console.ReadLine());

            var numAsString = numToCheck.ToString();
            
            var lim = numAsString.Length % 2 == 0 ? numAsString.Length / 2 : (numAsString.Length - 1) / 2;

            var isPalindrome = true;
            for (int i = 0; i < lim; i++)
            {
                if (!numAsString[i].Equals(numAsString[(numAsString.Length- 1) - i]))
                {
                    isPalindrome = false;
                    break;
                }
            }

            String message = isPalindrome ? "is a palintrome" : "is not a palindrome";
            Console.WriteLine($"{numToCheck} {message}");
        }
    }
}