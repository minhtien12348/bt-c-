using System;
using System.Collections.Generic;

public class SinhVien
{
    public string Name { get; set; }
    public int Semester { get; set; }
    public string CourseName { get; set; }

    public SinhVien(string name, int semester, string courseName)
    {
        Name = name;
        Semester = semester;
        CourseName = courseName;
    }

    public override string ToString()
    {
        return $"{Name}, {Semester}, {CourseName}";
    }
}
