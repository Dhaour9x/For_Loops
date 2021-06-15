using System;

namespace Summing_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum += num;

            }
            Console.WriteLine(sum);
        }
    }
}
