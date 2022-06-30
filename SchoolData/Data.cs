using SchoolDomain;
using System;

namespace SchoolData
{
    public class Data
    {
        public void CreateStudent(Student student)
        {
            Student.Students.Add(student);
        }

        public void CreateInstructor(Instructor instructor)
        {
            Instructor.Instructors.Add(instructor);
        }

        public void CreateCourse(Course course)
        {
            Course.Courses.Add(course);
        }
    }
}
