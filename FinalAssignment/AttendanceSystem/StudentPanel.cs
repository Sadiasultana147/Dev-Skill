using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem
{
    public class StudentPanel
    {
        public void StudentActivity()
        {
            
            
            var SA = new StudentAttendance();
            
            var User = new User();
            
           


            if (SA.Name==User.UserType)
            {
                Console.WriteLine("Name:  ");
                SA.Name = (Console.ReadLine());

                var context = new AttendanceDbContext();

                SA.AttenDanceDate = DateTime.Now;
                Console.WriteLine("CourseId:  ");
                var a = int.Parse(Console.ReadLine());
                SA.CourseId = a;
                var getClasses = context.Courses.Where(x => x.ID == a).Include("Classes").ToList();
                foreach (ClassSchedule classes in getClasses[0].Classes)
                {
                    var ClassTime = DateTime.Parse(classes.ClassDate + " " + classes.ClassStartTime);
                    if (SA.AttenDanceDate.Date == ClassTime.Date)
                    {
                        if(SA.AttenDanceDate>=ClassTime && SA.AttenDanceDate <= ClassTime.AddHours(3))
                        {
                            context.Attendances.Add(SA);

                            context.SaveChanges();



                            Console.WriteLine("Done");

                        }
                        else
                        {
                            Console.WriteLine("Attendance is not available");
                        }
                    }
                    else
                    {
                        Console.WriteLine(" Class is not available");
                    }
                }
                
                


            }


        }
        public static void GetStudent()
        {


            var context = new AttendanceDbContext();


            foreach (var student in context.Students)
            {
                Console.WriteLine("Student's ID: {0}, Student's Name: {1} ", student.Id, student.StudentName);

            }

        }
    }
}
