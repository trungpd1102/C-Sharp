using System;

namespace bai_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Me");

            var a = Tong(2, 4);
            Console.WriteLine(a);
        }

        /// <summary>
        /// Method returns sum of 2 integers
        /// </summary>
        /// <param name="a">So nguyen 1</param>
        /// <param name="b">So nguyen 2</param>
        /// <returns>TOng a + b</returns>
        static int Tong(int a, int b)
        {
            return a + b;
        }
    }
}
