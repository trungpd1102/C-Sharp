using System;

namespace MyNameSpace
{
    // class, struct, enum, interface ... đều cho phép khai báo namespace trong nó
    public class ClassOne
    {
        public static void Xinchao()
        {
            Console.WriteLine("Xin chao tu ClassOne");

        }
    }
    namespace ChildrenNamespace
    {
        public class ClassOne
        {
            public static void Xinchao()
            {
                Console.WriteLine("Xin chao tu ClassOne / ChildrenNamespace");

            }
        }
    }

}