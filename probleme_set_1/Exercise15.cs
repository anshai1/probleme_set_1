using System;

namespace ProgrammingProblems_Set_1
{
    public class Exercise15
    {
        public static void ThreeNumbersOrderly()
        {
            Console.WriteLine("Enter three numbers separated by a newline");
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            String order = "";
            
            if(a >= b && a >= c)
            {
                order = b >= c ? $"{c} - {b} - {a}" : $"{b} - {c} - {a}";
            }
            else if(b >= a && b >= c)
            {
                order = a >= c ? $"{c} - {a} - {b}" : $"{a} - {c} - {b}";
            }
            else if((c>=a)&&(c>=b))
            {
                order = a >= b ? $"{b} - {a} - {c}" : $"{a} - {b} - {c}";
            }
            
            Console.WriteLine(order);
        }
    }
}