using System;

namespace bai_17_dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            Student abc = new Student();
            PrintInfo(abc);
        }

        static void PrintInfo(dynamic obj)
        {
            obj.Name = "C#";
            obj.Hello();
        }

        class Student
        {
            public string Name { get; set; }
            public void Hello() => Console.WriteLine($"hello");

        }

    }
}
