using System;

namespace Problem_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            Ex01(ref x);

            int y = 10;
            Ex02(in y);

            int a = 0;
            int b = 0;
            Ex03(out a, out b);
        }

        public static void Ex01(ref int a)
        {
            a = 20;
        }

        public static void Ex02(in int a)
        {
            
        }

        public static void Ex03(out int a, out int b)
        {
            a = 50;
            b = 90;
        }
    }
}
