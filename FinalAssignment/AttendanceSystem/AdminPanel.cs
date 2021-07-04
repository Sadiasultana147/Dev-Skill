using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem
{
   public class AdminPanel
   {
       static string CreateUser;

        public  void AdminDuty()
       {
            Console.WriteLine("To Access Student Press S  ");
            Console.WriteLine("Or  ");
            Console.WriteLine("To Access Teacher Press T ");
            Console.WriteLine("Or  ");
            Console.WriteLine("To Access Course Press C ");
            Console.WriteLine("To Access Course  & Student Press CS ");
            Console.WriteLine("To Access  Class Shedule Press CLS ");
            CreateUser = Console.ReadLine();
             
            if (CreateUser == "S")
            {
                Console.WriteLine("Entry data of Student:");
                var context = new AttendanceDbContext();
                var student = new Student();
                // ******Adding Student******//

                Console.Write(" StudentName:");
                student.StudentName = Console.ReadLine();

                Console.Write(" DateOfBirth:");
                student.DateOfBirth = DateTime.Parse(Console.ReadLine());

                Console.Write(" Address:");
                student.Address = Console.ReadLine();
                
                
                
                context.Students.Add(student);

                context.SaveChanges();



                Console.WriteLine("Done");
            }

            else if (CreateUser == "T")
            {
                Console.WriteLine("Entry data of Teacher:");
                var context = new AttendanceDbContext();
                var teacher = new Teacher();

                // *****Adding Teacher*****//

                Console.Write(" TeacherName:");
                teacher.TeacherName = Console.ReadLine();
                Console.Write(" CourseId:");
                teacher.CourseID= int.Parse(Console.ReadLine());
                context.Teachers.Add(teacher);

                context.SaveChanges();



                Console.WriteLine("Done");

            }
            else if (CreateUser == "C")
            {
                Console.WriteLine("Entry data of Course:");
                var context = new AttendanceDbContext();
                var course = new Course();

                // *****Adding Teacher*****//
                Console.Write(" CourseTitle:");
                course.CourseName = Console.ReadLine();
                Console.Write(" Fees:");
                course.Fees = Decimal.Parse(Console.ReadLine());

                Console.Write(" ClassStartDate:");
                course.StartDate = DateTime.Parse(Console.ReadLine());
                Console.Write(" TotalClass:");
                course.TotalClass = int.Parse(Console.ReadLine());

                context.Courses.Add(course);

                context.SaveChanges();



                Console.WriteLine("Done");


            }
            else if (CreateUser == "CLS")
            {

                GetCourse();

                var context = new AttendanceDbContext();
                var course = new Course();
                var Classes = new ClassSchedule();
                Console.WriteLine("Enter CourseId");
                Classes.CourseID = int.Parse(Console.ReadLine());



                Console.WriteLine("Enter ClassDate");

                var ClassDate1 = DateTime.Parse(Console.ReadLine());
                Classes.ClassDate = ClassDate1.ToLongDateString();
                
                Classes.ClassStartTime = ClassDate1.ToShortTimeString();
               
                Classes.ClassEndTime = ClassDate1.AddHours(3).ToShortTimeString();

                context.Classes.Add(Classes);

                context.SaveChanges();

                

                Console.WriteLine("Done");
                Console.WriteLine($"{Classes.ClassDate} {Classes.ClassStartTime} - {Classes.ClassEndTime}");














            }
            else if (CreateUser == "CS")
            {
                /****************************************
                * Adding Course and Student
                * *************************************/
                var context = new AttendanceDbContext();
                var newStudent = new Student();
                Console.Write("StudentName:");
                newStudent.StudentName = Console.ReadLine();
                Console.Write("DateOfBirth:");
                newStudent.DateOfBirth = DateTime.Parse(Console.ReadLine());

                Console.Write("Address:");
                newStudent.Address = Console.ReadLine();

                var ListCourse = new CourseStudent();
                ListCourse.Student = newStudent;
                ListCourse.EnrollmentDate = DateTime.Now;

                var course = new Course();
                Console.Write("CourseTitle:");
                course.CourseName = Console.ReadLine();
                Console.Write("Fees:");
                course.Fees = Decimal.Parse(Console.ReadLine());
                Console.Write("ClassStartDate:");
                course.StartDate = DateTime.Parse(Console.ReadLine());
                course.EnrolledStudents = new List<CourseStudent>();
                course.EnrolledStudents.Add(ListCourse);

                context.Courses.Add(course);

                context.SaveChanges();
                Console.Write("CourseTitle:");
                var getCourse = context.Courses.Where(x => x.CourseName == Console.ReadLine())
                    .Include(b => b.EnrolledStudents)
                    .ThenInclude(t => t.Student)
                    .Include("Teachers").ToList();


                Console.WriteLine("Done");
            }





       }
        public static void GetCourse()
        {


            var context = new AttendanceDbContext();


            foreach (var course in context.Courses)
            {
                Console.WriteLine("Course's ID: {0}, Course's Name: {1} , ClassStartDate:{2} Total Class:{3}", course.ID, course.CourseName, course.StartDate, course.TotalClass);

            }

        }
   }

            

        

   
}
