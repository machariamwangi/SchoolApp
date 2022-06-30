using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDomain
{
   public class StudentCourse
    {
        public static List<StudentCourse> StudentCourses;

        static StudentCourse()
        {
            StudentCourses = new List<StudentCourse>();
        }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
