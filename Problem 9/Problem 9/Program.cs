using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;

            double  res;

            for (int i = 1; i < 501; i++)
            {
                a = i; 
                for (int j = 1; j < 501; j++)
                {
                    b = j;
                    c = (a * a) + (b * b);

                    res=a+b+Math.Sqrt (c);

                    if (res == 1000)
                    {
                        res = a * b * Math.Sqrt(c);
                        Console.WriteLine(res);
                        return;
                    }
                }

            }
        
        }
    }
}
