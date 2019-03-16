using System;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student;
            DNPStudent studentdnp = new DNPStudent();

            student = studentdnp;


            student.Hi();
        }
    }
}
