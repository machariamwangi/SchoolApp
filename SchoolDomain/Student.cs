using System;
using System.Collections.Generic;

namespace SchoolDomain
{
    public class Student
    {
        public static List<Student> Students;
        static Student()
        {
            Students = new List<Student>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public float Gpa { get; set; }
    }
}
