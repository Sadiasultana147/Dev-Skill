using System;

namespace Problem_10
{
    class Program
    {
        static void Main(string[] args)
        {
            HappyClass HC = new HappyClass();
            HC.ClassStartingTime = "9.00 pm";
            HC.ClassEndinTime = "11.00pm";
            HC.TotalTime = " 2 hours";
            Console.WriteLine(HC.ClassStartingTime);
            Console.WriteLine(HC.ClassEndinTime);
            Console.WriteLine(HC.ClassEndinTime);
        }
    }
}
