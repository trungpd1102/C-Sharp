using System;

namespace bai_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Console.ForegroundColor = ConsoleColor.Red;
            // Console.BackgroundColor = ConsoleColor.Black;
            // Console.WriteLine("Hello World!");

            // int a = 5;
            // int b = 2;

            // Console.WriteLine("a + b = {0}", a + b);
            // int i;

            // for (i = 0, Console.WriteLine("OK"); i < 10; i++)
            // {
            //     System.Console.WriteLine("Ok1");
            // }
            int i = 10;

            do
            {
                Console.WriteLine($"3 x {i} = {3 * i}");
                i++;
            }
            while (i < 10);
        }
    }
}
