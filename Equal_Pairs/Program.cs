using System;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                sum += num1 + num2;
                if (sum == num1+num2)
                {
                    Console.WriteLine("Yes, value="+ sum);
                }
                sum = 0;
            }
           
        }
    }
}
