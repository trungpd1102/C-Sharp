using System;
using System.Collections.Generic;
using System.Linq;

namespace bai_17_anonymous
{
    class Program
    {
        // Anonymous -  Kiểu dữ liệu vô danh
        // Object -  thuoc tinh- chi doc
        // new {thuoc tinh = giatri, thuoctinh2 = giatri2}
        static void Main(string[] args)
        {
            var sanpham = new
            {
                Ten = "Iphone",
                Gia = 100,
                NamSx = 2020
            };

            List<Student> students = new List<Student>(){
                new Student() {Name = "Trung", YearOfBirth = 1995, PlaceOfBirth = "Hai Duong"},
                new Student() {Name = "Nam", YearOfBirth = 1997, PlaceOfBirth = "Binh Duong"},
                new Student() {Name = "Y", YearOfBirth = 1995, PlaceOfBirth = "Ha Nam"},
                new Student() {Name = "Ngoc", YearOfBirth = 1992, PlaceOfBirth = "Hai Duong"},
                new Student() {Name = "Nguyet", YearOfBirth = 1998, PlaceOfBirth = "Hai Duong"},
                new Student() {Name = "Sang", YearOfBirth = 1995, PlaceOfBirth = "Nam Dinh"},
            };

            var result = from student in students
                         where student.YearOfBirth <= 1995
                         select new
                         {
                             Name = student.Name,
                             YearOfBirth = student.YearOfBirth,
                             PlaceOfBirth = student.PlaceOfBirth,
                         };

            foreach (var sinhvien in result)
            {
                Console.WriteLine($"Student: {sinhvien.Name}, Year of birth: {sinhvien.YearOfBirth}, Place of birth: {sinhvien.PlaceOfBirth}");
            }
        }

        class Student
        {
            public string Name { get; set; }
            public int YearOfBirth { get; set; }
            public string PlaceOfBirth { get; set; }
        }
    }
}
