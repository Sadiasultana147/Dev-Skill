using System;

namespace Problem_07
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = GetAB(10, 10.2);
            
        }
        public static double GetAB(int x, double y)
        {
            int a = x + 10;
            double b = y * 20;
            return (a + b);
        }

    }
}
