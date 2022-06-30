using SchoolBusiness;
using System;

namespace SchoolService
{
    public class Service
    {
        public void Controller(string methodName, string[] variables)
        {
            var business = new Business();
           
            switch (methodName.ToLower())
            {
                case "createstudent":
                    int studentId = Convert.ToInt32(variables[0]);
                    string studentName = variables[1];
                    float gpa = (float)Convert.ToDouble(variables[2]);
                    business.AddStudent(studentId, studentName, gpa);
                    break;
                case "createinstructor":
                    int instructorId = Convert.ToInt32(variables[0]);
                    string instructorName = variables[1];
                    business.AddInstructor(instructorId, instructorName );
                    break;
                case "createcourse":
                    int courseId = Convert.ToInt32(variables[0]);
                    string courseName = variables[1];
                    int credithours = Convert.ToInt32(variables[2]);
                    business.AddCourse(courseId, courseName, credithours);
                    break;
                case "addstudenttocourse":
                    int studentIdAssigned = Convert.ToInt32(variables[0]);
                    int courseIdAssigned = Convert.ToInt32(variables[1]);
                    business.AddStudentToCourse(studentIdAssigned, courseIdAssigned);
                    break;
            }
        }//AddStudentToCourse
    }
}
