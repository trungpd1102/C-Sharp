using System;

namespace bai_13_math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"pi: {Math.PI}, e: {Math.E}");

            // Max, Min
            Console.WriteLine($"max: {Math.Max(1, 2)}");

            // Abs tri tuyet doi
            // Sign: -1 if <0, 0 if ==0, 1 if>0
            // Lam tron
            double a = Math.Round(5.6); // 5.6 -> 6. 5.4 ->5
            // Math.Floor(); 5.1, 5.5, 5,7 -> 6
            // Math.Ceiling(); 5.1, 5.5, 5,7 -> 5
            // Math.Truncate(): cat phan thap phan
            Console.WriteLine(a);

        }
    }
}
