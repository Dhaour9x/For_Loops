using System;

namespace Numbers_Ending_by__7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1000;
            for (int i = 0; i < n; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
