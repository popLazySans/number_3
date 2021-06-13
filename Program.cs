using System;

namespace Last3
{
    class Program
    {
        static void Main(string[] args)
        {
            double count = 0;
            double RealNum = 0;
            double CompareNum = 0;
            double max = 0;
            double min = 0;
            double sum = 0;
            while (true)
            {
                
                string number = Console.ReadLine();
                if(number == "End")
                {
                    break;
                }
                CompareNum = double.Parse(number);
                if (RealNum<CompareNum)
                {
                    max = CompareNum;
                }
                else if(RealNum>CompareNum)
                {
                    min = CompareNum;
                }
                RealNum = CompareNum;
                count += 1;
                
                sum = sum + RealNum;
                
                
            }
            while (true)
            {
                string forUser = Console.ReadLine();
                if (forUser == "FindMax")
                {
                    Console.WriteLine(max);
                    break;
                }
                else if (forUser == "FindMin")
                {
                    Console.WriteLine(min);
                    break;
                }
                else if (forUser == "FindMean")
                {
                    Console.WriteLine(sum/count);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid mode");
                }
            }
        }
    }
}
