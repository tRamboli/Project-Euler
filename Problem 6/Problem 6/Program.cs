using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            long dif;
            dif = Sumsquare(100) - Sqaresum(100);
            Console.WriteLine(dif);
            
        }


        static long Sumsquare(int cnt)
        {
            
            int sum = 0;
            for (int i = 0; i < cnt; i++)
            {

                sum +=( i + 1);
               
            }
            return (sum * sum);


        }

        static long Sqaresum(int cnt)
        {
            long[] a = new long[cnt];
            long suma = 0;
          
            for (int i = 0; i < cnt ; i++)
            {

                a[i] = (i+1)*(i+1);
                suma += a[i];

            }
            return suma;
        }
    }
}
