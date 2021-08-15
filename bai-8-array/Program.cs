using System;
using System.Linq;

namespace bai_8_array
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] numbers = { 1, 2, 3, 4, 5, 6 };

            // // studentList = new string[3];
            // // foreach (int i in studentList)
            // // {
            // //     Console.WriteLine(i);
            // // }
            // Console.WriteLine($"so phan tu :{numbers.Length}");
            // Console.WriteLine($"chieu :{numbers.Rank}");

            // Console.WriteLine($"Min :{numbers.Min()}");
            // Console.WriteLine($"Max :{numbers.Max()}");
            // Console.WriteLine($"Sum :{numbers.Sum()}");

            /*
                     0 1 2

                0    2 4 5
                1    2 4 5          
            */
            double[,] numbers = new double[2, 3] { { 2, 4, 5 }, { 1, 2, 3 } };

            Console.WriteLine(numbers[1, 2]);


        }
    }
}
