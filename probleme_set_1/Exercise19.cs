using System;
using System.Collections.Generic;

namespace ProgrammingProblems_Set_1
{
    public class Exercise19
    {
        public static void FormedOf2Numbers()
        {   
            Console.WriteLine("Please enter your integer: ");
            var a = int.Parse(Console.ReadLine());
            var characters = new HashSet<char>();
            var numAsString = a.ToString();

            var charCount = 0;

            foreach (var c in numAsString)
            {
                if (characters.Add(c))
                {
                    charCount++;
                }
            }

            var message = charCount == 2
                ? "The number entered is formed of 2 digits"
                : "The number entered is not formed of 2 digits";
            
            Console.WriteLine(message);
        }
    }
}