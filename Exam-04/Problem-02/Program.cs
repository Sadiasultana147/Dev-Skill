using System;

namespace Problem_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the the number of test cases.");
            var TestCase = Console.ReadLine();
            int Case = int.Parse(TestCase);

            Console.WriteLine("Write the the number of Orginal Phone List.");
            int PhnListNo = int.Parse(Console.ReadLine());
            string[] Phnlist = new string[PhnListNo];
            //int endtime = 0;
            string[] SuccessList = new string[PhnListNo];
            string[] FailedList = new string[PhnListNo];


            string[] C2 = new string[] { "Success", "Failed" };



            for (int j = 0; j < PhnListNo; j++)
            {
                var multivalue1 = Console.ReadLine();

                Phnlist[j] = multivalue1;





            }

            for (int k = 0; k < PhnListNo; k++)
            {
                var multivalue = Console.ReadLine();
                var lineParts1 = multivalue.Split(',');
                string Sphn1 = lineParts1[0];
                string SComment = lineParts1[1];


                if (lineParts1[1] == C2[0])
                {
                    SuccessList[k] = $"SuccessList: { Sphn1} : { Phnlist[k]}";

                    


                }


                else if (SComment == C2[1])
                {
                    FailedList[k] = $"FailedList:{ Sphn1}:{ Phnlist[k]}";

                   

                }



            }
            Console.WriteLine("SuccessList:");
            for (int a = 0; a < SuccessList.Length; a++)
            {
                Console.WriteLine($"{SuccessList[a]}");
            }
            Console.WriteLine("FailedList:");
            for (int a = 0; a < FailedList.Length; a++)
            {
                Console.WriteLine(FailedList[a]);
            }
        }
    }
}
