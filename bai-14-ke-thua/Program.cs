using System;

namespace bai_14_ke_thua
{
    /*

        Tinh ke thua
        A, B
        B ke thua A
        A - cơ sở, cha
        B - kế thừa, con

        class B : A // B kế thừa từ A
        {

        }

        Animal
            - Legs
            - Weight
            - ShowLegs

        Cat : Animal

        sealed: không cho kế thừa từ class có từ khóa này
    */
    class Animal
    {

        public int Legs { get; set; }

        public float Weight { get; set; }

        public Animal()
        {
            Console.WriteLine("Khoi tao class Animal");
        }

        public Animal(int num)
        {
            Console.WriteLine($"Khoi tao Animail {num}");

        }
        public void ShowLegs()
        {
            Console.WriteLine($"Legs: {Legs}");

        }
    }

    class Cat : Animal
    {
        public string Food { get; set; }

        // Dùng phương thức khởi tạo xác định
        public Cat(int num) : base(num)
        {
            Console.WriteLine("Khoi tao class Cat");
            this.Legs = 4;
            this.Food = "Mouse";
        }

        public void Eat()
        {
            Console.WriteLine($"Cat eat {Food}");
        }

        // Định nghĩa lại phương thức ở lớp ké thừa
        public new void ShowLegs()
        {
            Console.WriteLine($"Loai meo co {Legs} chan");
        }

        public void ShowInfo()
        {
            // Gọi showLegs() ở lớp cha
            base.ShowLegs();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat(2);
            cat.Food = "Fish";
            cat.ShowLegs();
            cat.ShowInfo();
        }
    }
}
