using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDomain
{
    public class Course
    {
        public static List<Course> Courses;

        static Course()
        {
            Courses = new List<Course>();
        }
        public int Id { get; set; }
        public string CourseName { get; set; }
        public int CreeditHours { get; set; }
    }
}
