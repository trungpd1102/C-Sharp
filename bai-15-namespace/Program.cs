using System;
using MyNameSpace;
// Đặt tên tắt
using Abbreviation = MyNameSpace.ChildrenNamespace;
using Sanpham;

namespace bai_15_namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassOne.Xinchao();
            Abbreviation.ClassOne.Xinchao();

            Product product = new Product();

            product.name = "Iphone";
            product.price = 1000;
            product.description = "Apple Product";

            Console.WriteLine(product.GetInfo());

        }
    }
}
