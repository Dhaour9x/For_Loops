using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            var counter1 = 0;
            var counter2 = 0;
            var counter3 = 0;
            var counter4 = 0;
            var counter5 = 0;
            for (int i = 0; i < n; i++)
            {
                double num = int.Parse(Console.ReadLine());

                if (num <200)
                {
                    counter1++;
                    p1 = counter1 / n * 100;
                }
                else if (num < 400 && num >= 200)
                {
                    counter2++;
                    p2 = counter2 / n * 100;
                }
                else if (num < 600 && num >= 400)
                {
                    counter3++;
                    p3 = counter3 / n * 100;
                }
                else if (num <800 && num >= 600)
                {
                    counter4++;
                    p4 =counter4 / n * 100;
                }
                else if (num >= 800)
                {
                    counter5++;
                    p5 = counter5 / n * 100;
                }
            }
            Console.WriteLine("{0:f2}%" ,p1);
            Console.WriteLine("{0:f2}%", p2);
            Console.WriteLine("{0:f2}%", p3);
            Console.WriteLine("{0:f2}%", p4);
            Console.WriteLine("{0:f2}%", p5);
        }
    }
}
