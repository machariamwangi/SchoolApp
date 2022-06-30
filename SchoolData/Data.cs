using SchoolDomain;
using System;
using System.Linq;

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

        public Student GetStudent(int studentId)
        {
            return Student.Students.Where(x => x.Id == studentId).FirstOrDefault();
        }

        public Course GetCourse(int courseId)
        {
            return Course.Courses.Where(x => x.Id == courseId).FirstOrDefault();
        }

        public void CreateStudentCourse(StudentCourse studentCourse)
        {
            StudentCourse.StudentCourses.Add(studentCourse);
        }
    }
}
