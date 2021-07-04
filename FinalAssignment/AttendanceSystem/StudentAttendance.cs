using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem
{
    public class StudentAttendance
    {
        public int ID { get; set; }
        public string Name{ get;set;}
        public DateTime AttenDanceDate { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
