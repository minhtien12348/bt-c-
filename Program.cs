using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding=UTF8Encoding.UTF8;
        List<SinhVien> danhSach = new List<SinhVien>
        {
            new SinhVien("Nguyen Van A", 1, "Java"),
            new SinhVien("Tran Thi B", 2, ".Net"),
            new SinhVien("Le Van C", 3, "C/C++")
        };

        while (true)
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Xem danh sách");
            Console.WriteLine("2. Tìm kiếm theo tên");
            Console.WriteLine("3. Thêm sinh viên");
            Console.WriteLine("4. Sửa sinh viên");
            Console.WriteLine("5. Xóa sinh viên");
            Console.WriteLine("6. Thoát");
            Console.Write("Chọn: ");
            string chon = Console.ReadLine();

            if (chon == "1")
            {
                foreach (var sv in danhSach)
                    Console.WriteLine(sv);
            }
            else if (chon == "2")
            {
                Console.Write("Nhập tên cần tìm: ");
                string key = Console.ReadLine().ToLower();
                bool found = false;
                foreach (var sv in danhSach)
                {
                    if (sv.Name.ToLower().Contains(key))
                    {
                        Console.WriteLine(sv);
                        found = true;
                    }
                }
                if (!found) Console.WriteLine("Không tìm thấy.");
            }
            else if (chon == "3")
            {
                Console.Write("Tên: ");
                string name = Console.ReadLine();

                Console.Write("Học kỳ (số): ");
                if (!int.TryParse(Console.ReadLine(), out int sem))
                {
                    Console.WriteLine("Học kỳ phải là số!");
                    continue;
                }

                Console.Write("Môn học (Java/.Net/C/C++): ");
                string course = Console.ReadLine();

                danhSach.Add(new SinhVien(name, sem, course));
                Console.WriteLine("Đã thêm.");
            }
            else if (chon == "4")
            {
                Console.Write("Nhập tên sinh viên cần sửa: ");
                string target = Console.ReadLine();
                SinhVien sv = danhSach.Find(s => s.Name.Equals(target, StringComparison.OrdinalIgnoreCase));

                if (sv == null) { Console.WriteLine("Không tìm thấy."); continue; }

                Console.Write("Tên mới (Enter để giữ): ");
                string newName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newName)) sv.Name = newName;

                Console.Write("Học kỳ mới (Enter để giữ): ");
                string semStr = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(semStr) && int.TryParse(semStr, out int newSem))
                    sv.Semester = newSem;

                Console.Write("Môn học mới (Enter để giữ): ");
                string newCourse = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newCourse)) sv.CourseName = newCourse;

                Console.WriteLine("Đã sửa.");
            }
            else if (chon == "5")
            {
                Console.Write("Nhập tên sinh viên cần xóa: ");
                string target = Console.ReadLine();
                SinhVien sv = danhSach.Find(s => s.Name.Equals(target, StringComparison.OrdinalIgnoreCase));

                if (sv != null)
                {
                    danhSach.Remove(sv);
                    Console.WriteLine("Đã xóa.");
                }
                else Console.WriteLine("Không tìm thấy.");
            }
            else if (chon == "6")
            {
                break;
            }
            else
            {
                Console.WriteLine("Lựa chọn không hợp lệ.");
            }
        }
        Console.ReadKey();
    }
}
