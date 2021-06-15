using System;

namespace Even_Odd_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOdd = 0;
            int sumEven = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumOdd += num;
                }
                else
                {
                    sumEven += num;
                }
            }

            if (sumEven == sumOdd)
            {
                Console.WriteLine("Yes, sum = "+sumEven);
            }
            else
            {
                Console.WriteLine("NO, diff = "+ Math.Abs(sumEven-sumOdd));
            }
            
        }
    }
}
