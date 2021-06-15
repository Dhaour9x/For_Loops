using System;

namespace Element_Equal_to_the_Sum_of_the_Rest
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                max = max > num ? max : num;
                sum += num;
            }
            sum -= max;
            if (sum == max)
            {
                Console.WriteLine("Yes" + max);
            }
            else
            {
                Console.WriteLine("No" + Math.Abs(sum - max));
            }
        }
    }
}
