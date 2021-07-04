using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem
{
    public class TeacherPanel
    {
        public void TeacherActivity()
        {
            var context = new AttendanceDbContext();

            var Teacher = new Teacher();
            var SA = new StudentAttendance();
            
            var student = new Student();
            Console.WriteLine("StudentList:");

            GetStudent();
            Console.WriteLine("StudentAttendanceList:");
            GetAttendance();
            Console.WriteLine("Student CourseId:");
            var CourseId = int.Parse(Console.ReadLine());
            
            var getCourse = context.Students.Where(x => x.Id == CourseId).Include("EnrolledCourses").ToList();

            var IDToMatche = 0;
            foreach(CourseStudent Cs in getCourse[0].EnrolledCourses)
            {
                IDToMatche = Cs.CourseID;

            }
            Console.WriteLine("Teacher CourseId:");
           var CourseID2 = int.Parse(Console.ReadLine());
            //var getCourse1 = context.Teachers.Where(x => x.Id == CourseID2).ToList();

            
            foreach( Teacher t in context.Teachers)
            {
                if (t.CourseID == IDToMatche)
                {
                    Console.WriteLine("StudentName:");
                    student.StudentName = Console.ReadLine();
                    //var getStudents = context.Students.ToList();
                    //var getAttendance = context.Attendances.ToList();
                    var a = 0;
                    foreach(StudentAttendance s in context.Attendances)
                    {
                        if (s.Name == student.StudentName)
                        {
                            
                            a++;
                            
                        }
                        
                    }
                    if (a > 0)
                    {
                        Console.WriteLine("Present");
                    }
                    else
                    {
                        Console.WriteLine("Absent");
                    }
                }

            }
           
           
            
                
            

        }
        public static void GetStudent()
        {


            var context = new AttendanceDbContext();
            var getStudents = context.Students.ToList();
            

            foreach (var student in context.Students)
            {
                Console.WriteLine("Student's ID: {0}, Student's Name: {1} ", student.Id, student.StudentName);

            }

        }
        public static void GetAttendance()
        {


            var context = new AttendanceDbContext();
            var getAttendance = context.Attendances.ToList();


            foreach (var students in context.Attendances)
            {
                Console.WriteLine("Student's ID: {0}, Student's Name: {1} ", students.ID, students.Name);
                

            }

        }

    }
}
