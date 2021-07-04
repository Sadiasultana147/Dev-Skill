using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
       
       
        public List<CourseStudent>EnrolledCourses { get; set; }

        

    }
}
