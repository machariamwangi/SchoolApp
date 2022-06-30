using SchoolService;
using System;

namespace SchoolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new Service();
           service.Controller("CreateStudent", new string[]{"1", "Bob Smit", "0"});
           service.Controller("CreateInstructor", new string[] { "1", "sheriff" });
           service.Controller("CreateCourse", new string[] { "1", "Science", "3" });
            service.Controller("AddStudentToCourse", new string[] { "1", "1"});
        }
    }
}
