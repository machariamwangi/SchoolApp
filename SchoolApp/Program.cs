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
        }
    }
}
