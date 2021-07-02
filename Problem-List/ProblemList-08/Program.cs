using System;

namespace ProblemList_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the the number of test cases.");
            var TestCase = Console.ReadLine();

            int Case = int.Parse(TestCase);
            Console.WriteLine($" Number of Test Case:{Case}");

            for (int i = 0; i < Case; i++)
            {
                Console.WriteLine("Write the number of 1st Match");



                var multiValue = Console.ReadLine();






                var lineParts = multiValue.Split(' ');
                int firstMatch1 = int.Parse(lineParts[0]);
                int firstMatch2 = int.Parse(lineParts[1]);
                int firstMatch3 = int.Parse(lineParts[2]);
                int firstMatch4 = int.Parse(lineParts[3]);
                Console.WriteLine("Write the number of 2nd Match");
                var multivalue = Console.ReadLine();
                var lineParts1 = multivalue.Split(' ');
                int secondMatch1 = int.Parse(lineParts1[0]);
                int secondMatch2 = int.Parse(lineParts1[1]);
                int secondMatch3 = int.Parse(lineParts1[2]);
                int secondMatch4 = int.Parse(lineParts1[3]);

                int TotalScoreBD = firstMatch1 + firstMatch2 + secondMatch1 + secondMatch2;
                int TotalScorePK = firstMatch3 + firstMatch4 + secondMatch3 + secondMatch4;


                Console.WriteLine($" Result Of 1st Match:");
                Console.WriteLine($" Bangladesh:{firstMatch1}");
                Console.WriteLine($" Bangladesh:{firstMatch2}");
                Console.WriteLine($" Pakistan:{firstMatch3}");
                Console.WriteLine($" Pakistan:{firstMatch4}");
                Console.WriteLine("Result Of second match:");
                Console.WriteLine($" Bangladesh:{secondMatch1}");
                Console.WriteLine($" Bangladesh:{secondMatch2}");
                Console.WriteLine($" Pakistan:{secondMatch3}");
                Console.WriteLine($" Pakistan:{secondMatch4}");
                Console.WriteLine();
                Console.WriteLine($" ToTalScore Of BD:{TotalScoreBD}");
                Console.WriteLine($" Total Score Of PK:{TotalScorePK}");
                Console.WriteLine();
                Console.WriteLine($" FinalResult:");

                if (TotalScoreBD > TotalScorePK)
                {
                    Console.WriteLine($" BanglaWash");

                }
                else
                {
                    Console.WriteLine($" Miss");
                }
            }
        }
    }
}
