using System;

namespace ProblemList_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the number of Total WorkHours And Members");


            int endtime = 0;
            for (int i = 0; i <= endtime; i++)
            {
                var multiValue = Console.ReadLine();
                if (multiValue == "end" || multiValue == string.Empty)
                {
                    break;
                }
                else
                {
                    var lineParts = multiValue.Split(' ');
                    string TotalHours = lineParts[0];
                    int Hours = int.Parse(TotalHours);
                    string TotalMembers = lineParts[1];
                    int Members = int.Parse(TotalMembers);
                    Console.WriteLine("Enter Worktime of Each member");
                    int TotalTime = 0;
                    int Day1;
                    int Day2;
                    int Day3;




                    for (int k = 0; k < Members; k++)
                    {
                        var multivalue1 = Console.ReadLine();

                        int EachMember = int.Parse(multivalue1);
                        TotalTime += EachMember;




                    }




                    Day1 = Hours / TotalTime;
                    Day2 = Hours % TotalTime;


                    Day3 = Day1 + 2;

                    if (Day2 == 0)
                    {

                        Console.WriteLine($"Project Will finished  Within {Day1} Days");
                    }
                    else
                    {
                        Console.WriteLine($"Project Will finished  Within {Day3} Days");
                    }










                }
                endtime++;
            }
    }   }
}
