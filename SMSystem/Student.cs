using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SMSystem.Enums;

namespace SMSystem
{
    public class Student
    {
        public Student()
        {
            SemestersAttended = new List<Semester>();
            AttendedCourse = new List<Course>();
            JoiningBatch = string.Empty;

        }
        public string FirstName { get; set; }

        public string LastName { get; set; } = string.Empty;
        public string MidlleName { get; set; } = string.Empty;
        public string StudentId { get; set; } = string.Empty;
        public string ? JoiningBatch {  get; set; }
        public Dept Department { get; set; } = Dept.None;
        public Degree Degree { get; set; } = Degree.None;
        public List<Course> AttendedCourse { get; set; }
        public List<Semester> SemestersAttended { get; set; }
    }
}
