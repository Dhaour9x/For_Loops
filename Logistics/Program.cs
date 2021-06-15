using System;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());
            var counter1 = 0;
            var counter2 = 0;
            var counter3 = 0;

            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double tons = int.Parse(Console.ReadLine());
               
                    sum+= tons;
                if (tons <= 3)
                {
                    sum1 += tons;
                    counter1++;
                    var minibus = 200 * sum1;
                    
                    
                }
                else if (tons> 3 && tons <= 11)
                {
                    counter2++;
                    var truck = tons * 175;
                    sum2 += tons;
                   
                }
                else if (tons>11)
                {
                    counter3++;
                    var train = tons * 120;
                    sum3 += tons;
                    
                }

            }
            p1 = sum1 / sum * 100;
            p2 = sum2 / sum * 100;
            p3 = sum3 / sum * 100;
            double average = (sum1 * 200 + sum2 * 175 + sum3 * 120)/sum;
            Console.WriteLine(average);
            Console.WriteLine("{0:f2}%",p1);
            Console.WriteLine("{0:f2}%",p2);
            Console.WriteLine("{0:f2}%",p3);
        }
    }
}
