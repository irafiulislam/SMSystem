using System;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using static SMSystem.Enums;
using SMSystem;

namespace SMS
{
    internal class Program
    {
        //public static List<Student> students = new List<Student>();

        public static object StudentCourseMethod { get; private set; }

        static void Main(string[] args)
        {
            var students = SemesterCourseMethod.LoadStudent();


            while (true)
            {

                Console.WriteLine("1. Add A New Student");
                Console.WriteLine("2. View Student Details");
                Console.WriteLine("3. Delete Student");
                Console.WriteLine("4. Add Semester and Course");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1: SemesterCourseMethod.AddStudent(students); break;
                    case 2: SemesterCourseMethod.ViewStudent(students); break;
                    case 3: SemesterCourseMethod.DeleteStudent(students); break;
                    case 4: SemesterCourseMethod.AddSemester(students); break;

                    default: Console.WriteLine("Invalid Choices"); break;
                }
               SemesterCourseMethod.SaveStudents(students);
            }
           
        }
    }
}