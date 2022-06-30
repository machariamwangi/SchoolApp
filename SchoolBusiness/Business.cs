using SchoolData;
using SchoolDomain;
using System;

namespace SchoolBusiness
{
    public class Business
    {
        public void AddStudent(int id, string name, float gpa)
        {
            var data = new Data();
            var student = new Student()
            {
                Id = id,
                Name = name,
                Gpa = gpa
            };

            data.CreateStudent(student);

        }

        public void AddInstructor(int instructorId, string instructorName)
        {
            var data = new Data();
            var instructor = new Instructor()
            {
                Id = instructorId,
                Name = instructorName
            };

            data.CreateInstructor(instructor);
        }

        public void AddCourse(int courseId, string courseName, int credithours)
        {
            var data = new Data();
            var course = new Course()
            {
                Id = courseId,
                CourseName = courseName,
                CreeditHours = credithours
            };

            data.CreateCourse(course);
        }
    }
}
