using System;

namespace Problem_06
{
    class Program
    {
        static void Main(string[] args)
        {

            MyGenericClass<String, int> x = new MyGenericClass<string, int>();
            x.a = "Hello";
            x.b = 5;
            Console.WriteLine(x.a);

            Console.WriteLine(x.b);


        }
    }
}
