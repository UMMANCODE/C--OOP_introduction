using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp16 {
    internal class Student {

        public Student(string fullname, double point) {
            Fullname = fullname;
            Point = point;
        }

        public Student(string fullname, double point, string groupNo, DateTime birthDate)
        : this(fullname, point) {
            GroupNo = groupNo;
            BirthDate = birthDate;
        }


        public string Fullname;
        public string GroupNo;
        public double Point;
        public DateTime BirthDate;

        public void ShowInfo() {
            Console.WriteLine($"Fullname: {Fullname}");
            Console.WriteLine($"GroupNo: {GroupNo}");
            Console.WriteLine($"Point: {Point}");
            Console.WriteLine($"BirthDate: {BirthDate:dd/MM/yyyy}");
        }
    }
}
