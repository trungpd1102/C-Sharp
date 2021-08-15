using System;

namespace bai_16_generic
{
    class Program
    {
        static void Main(string[] args)
        {
            // string a = "a";
            // string b = "b";

            // Console.WriteLine($"a = {a}, b = {b}");
            // Swap(ref a, ref b);
            // Console.WriteLine($"a = {a}, b = {b}");

            Product<string> product1 = new Product<string>();
            product1.SetID("SP1");
            product1.ShowID();
        }

        static void Swap<T>(ref T x, ref T y)
        {
            T t = x;
            x = y;
            y = t;
        }

        class Product<T>
        {
            T ID;

            public void SetID(T id)
            {
                this.ID = id;
            }

            public void ShowID()
            {
                Console.WriteLine($"ID: {this.ID}");

            }
        }
    }
}
