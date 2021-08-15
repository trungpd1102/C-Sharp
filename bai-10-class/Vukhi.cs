using System;

namespace bai_10_class
{
    //<Access Modifiers> class Class_Name {
    // khai báo các thành viên dữ  liệu (thuộc tính, biến trường dữ liệu)
    // khai báo các thành viên  hàm (phương thức)

    public class Vukhi
    {
        // Du lieu
        // Mac dinh la private
        public string name = "Ten vu khi";
        int doSatThuong = 0;


        // Phương thức khởi tạo: constructor
        // Có tên trùng với tên class
        // Khởi tạo giá trị các biến ....
        public Vukhi()
        {
            // Console.WriteLine($"Khoi tao");
            doSatThuong = 1;
        }

        // Có thể có nhiều constructor
        public Vukhi(string gunName)
        {
            Console.WriteLine("Day la sung {0}", gunName);

        }

        public Vukhi(string name, int _doSatThuong)
        {
            doSatThuong = _doSatThuong;
            this.name = name;
        }

        // Thuoc tinh 
        public int Satthuong
        {
            set
            {
                // this.doSatThuong = value;
                Console.WriteLine(value);

            }

            get
            {
                Console.WriteLine($"get");
                return doSatThuong;
            }
        }

        // Phuong thuc
        public void ThietLapDoSatThuong(int doSatThuong)
        {
            this.doSatThuong = doSatThuong;
            // this: tham chieu den doi tuong hien tai
        }

        public void TanCong()
        {
            Console.WriteLine(this.name);
            for (int i = 0; i < doSatThuong; i++)
            {
                Console.Write($" * ");

            }
            Console.WriteLine();

        }

        public static void Log()
        {
            Console.WriteLine($"OK");

        }
    }
}