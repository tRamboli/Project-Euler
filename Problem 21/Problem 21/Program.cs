using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_21
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum=0;
            long n=0;
            for (long i = 1; i < 10000; i++)
            {
               n=D(i);
               if (D(n) == i && n != i)
                   sum += i;
                
            }

            Console.WriteLine(sum);

        }

        static long D(long num)
        {
            long sum = 0;

            for (int i = 1; i <= num/2; i++)
            {
                if (num % i == 0)
                    sum += i;
                
            }

            return sum;
        }
    }
}
