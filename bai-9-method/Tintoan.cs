using System;

namespace bai_9_method
{
    public class Tinhtoan
    {
        public static int Tong(Info input)
        {
            return input.soA + input.soB;
        }

        public class Info
        {
            public int soA { get; set; }
            public int soB { get; set; }
        }
    }
}