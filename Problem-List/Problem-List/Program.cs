using System;

namespace Problem_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the Number of Test Case ");
            var TestCase = int.Parse(Console.ReadLine());
            Console.WriteLine("Write  number separated by comma");
            for (int i = 0; i < TestCase; i++)
            {
                var multiValueInSingleLine = Console.ReadLine();

                var lineParts = multiValueInSingleLine.Split(',');
                int number1 = int.Parse(lineParts[0]);


                int number2 = int.Parse(lineParts[1]);




                int rem;
                int reverse1 = 0;
                int reverse2 = 0;
                while (number1 != 0 && number2 != 0 && number1 > 0 && number2 > 0)
                {
                    rem = number1 % 10;
                    reverse1 = reverse1 * 10 + rem;
                    number1 /= 10;
                    rem = number2 % 10;
                    reverse2 = reverse2 * 10 + rem;
                    number2 /= 10;
                }
                Console.WriteLine($"1st reverse number:{reverse1}");
                Console.WriteLine($"2nd reverse number:{reverse2}");
                int sum = reverse1 + reverse2;

                int reverseSum = 0;
                while (sum != 0)
                {
                    rem = sum % 10;
                    reverseSum = reverseSum * 10 + rem;
                    sum /= 10;

                }
                Console.WriteLine($"Reverse Of Sum:{reverseSum}");
            }
        }
    }
}
