using System;

namespace Problem_03
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic o = new { firstStatement = "hello", SecondStatement = "world" };
            Console.WriteLine(o.firstStatement);
            Console.WriteLine(o.SecondStatement);
        }
    }
}
