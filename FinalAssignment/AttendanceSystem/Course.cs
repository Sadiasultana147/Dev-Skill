using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem
{
    public class Course
    {
        public int ID { get; set; }
        public string CourseName { get; set; }
        public decimal Fees { get; set; }
        public DateTime StartDate { get; set; }
        public int TotalClass { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<CourseStudent> EnrolledStudents { get; set; }
        public List<ClassSchedule> Classes { get; set; }
        public List<StudentAttendance> Attendances { get; set; }
        


    }
}
