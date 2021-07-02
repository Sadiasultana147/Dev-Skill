using System;

namespace ProblemList_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any number: ");



            int endtime = 0;
            for (int i = 0; i <= endtime; i++)
            {
                var num = Console.ReadLine();
                int num1 = Convert.ToInt32(num);
                if (num == "end" || num == string.Empty)
                {
                    break;
                }
                else
                {
                    int r = 0;

                    for (int j = 2; j <= num1 / 2; j++)
                    {
                        if (num1 % j == 0)
                        {
                            r = 1;

                            break;
                        }


                    }

                    if (r == 0)
                    {
                        Console.WriteLine("It is a Prime Number");
                    }

                    else
                    {
                        Console.WriteLine("It is not a Prime Number");

                    }

                }
                endtime++;
            }
        }
    }
}
