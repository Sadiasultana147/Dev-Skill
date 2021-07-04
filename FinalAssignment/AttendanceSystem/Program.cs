using System;

namespace AttendanceSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new AttendanceDbContext();



            //*** Add User **//
            User User = new User();

            Console.WriteLine("Enter User details");

            Console.Write("UserType: ");
            var UserType = Console.ReadLine();
            Console.Write("UserName: ");
            var UserName = Console.ReadLine();
            Console.Write("Password: ");
            var Password = Console.ReadLine();

            User.UserType = UserType;
            User.UserName = UserName;
            User.Password = Password;

            context.Users.Add(User);

            context.SaveChanges();
            Console.WriteLine("done");
            Console.WriteLine($"UserType:{User.UserType} UserName:{User.UserName} Password:{User.Password}");


            //*** login**//

            //Console.WriteLine("Enter your UserName and Password to log in.");
            //Console.Write("Username: ");
            //var userName = Console.ReadLine();

            //Console.Write("Password: ");
            //var userPassword = Console.ReadLine();
            //string userType = string.Empty;
            //int userID = 0;
            //foreach (User u in context.Users)
            //{
            //    if (userName == u.UserName && userPassword == u.Password)
            //    {
            //        Console.WriteLine("{0} login successfull", u.UserType);
            //        userType = u.UserType;
            //        userID = u.ID;
            //        break;
            //    }
            //}
            //context.SaveChanges();
            //if (userType == "Admin")
            //{
            //    var adminPanel = new AdminPanel();


            //    adminPanel.AdminDuty();

            //}
            //else if (userType == "Student")
            //{
            //    var studentPanel = new StudentPanel();


            //    studentPanel.StudentActivity();

            //}
            //else if (userType == "Teacher")
            //{
            //    var TeacherPanel = new TeacherPanel();


            //    TeacherPanel.TeacherActivity();

            //}
        }
    }
}
