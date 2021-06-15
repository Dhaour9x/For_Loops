using System;

namespace Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double oddSum = 0;
            double evenSum = 0;
            double oddMax = 0;
            double oddMin = 0;
            double evenMax = 0;
            double evenMin = 0;
            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    evenSum += num;
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                    else
                    {
                        evenMin = num;
                    }
                }
                else
                {
                    oddSum += num;
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                    else
                    {
                        oddMin = num;
                    }
                    
                }
            }
            Console.WriteLine(evenSum.ToString());
            Console.WriteLine(evenMax);
            Console.WriteLine(evenMin);
            Console.WriteLine(oddSum);
            Console.WriteLine(oddMax);
            Console.WriteLine(oddMin);
        }
    }
}
