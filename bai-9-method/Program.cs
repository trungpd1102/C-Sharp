using System;


// void: ham khong return
// static: co the goi k can tao moi class
// public: co the goi tu ngoai class
// private: chi goi duoc trong cung 1 class
// protected: chi goi trong lop va lop ke thua tu no
namespace bai_9_method
{
    class Program
    {
        public static void Main(string[] args)
        {
            var result = Tinhtoan.Tong(new MyClass());
            Console.WriteLine(result);
            // var fullName = name(ten: "Trung", ho: "Pham");
            // Console.WriteLine(fullName);
            // int a;
            // binhphuong(4, out a);
            // Console.WriteLine(a);

        }

        public class MyClass
        {
            public int soA = 2;
            public int soB = 3;
        }

        public static int tich(int a, int b)
        {
            return a * b;
        }

        public static string name(string ho, string ten)
        {
            return ho + " " + ten;
        }

        static void binhphuong(int x, out int kq)
        {
            kq = x * x;
        }
    }
}
