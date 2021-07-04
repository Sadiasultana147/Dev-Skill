using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem
{
    public class Teacher
    {
        public int Id { get; set; }
        public string TeacherName { get; set; }

        public int CourseID { get; set; }
        public Course Course { get; set; }
    }
}
