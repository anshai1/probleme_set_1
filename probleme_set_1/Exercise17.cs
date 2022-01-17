using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ProgrammingProblems_Set_1
{
    public class Exercise17
    {
        public static void Euclid()
        {
            Console.WriteLine("Introduceti 2 numere a si b ( unde a > b) separate de un Enter, pentru a afla cel mai mare divizor comun si cel mai mic multiplu comun");
            MessageUtils.InputForVariableNamed("a");
            var a = int.Parse(Console.ReadLine());   
            MessageUtils.InputForVariableNamed("b");
            var b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Cel mai mare divizor comun: {CelMaiMareDivizorComun(a, b)}");
            Console.WriteLine($"Cel mai mic multiplu comun: {CelMaiMicMultipluComun(a, b)}");
        }

        public static int CelMaiMareDivizorComun(int a, int b)
        {
            while (b != 0)
            {
                var oldB = b;
                b = a % b;
                a = oldB;
            }

            return a;
        }

        public static int CelMaiMicMultipluComun(int a, int b)
        {
            return (a / CelMaiMareDivizorComun(a, b)) * b;
        }
        
    }
}