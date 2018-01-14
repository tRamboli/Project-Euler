using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_14
{
    class Program
    {
        static void Main(string[] args)
        {

            int ind = 0;
            long res;
            long max = -1;
            for (int i = 1; i < 1000000; i++)
            {
                res = RerChainCnt(i);
                if (res > max)
                {
                    max = res;
                    ind = i;
                }

            }
            Console.WriteLine(ind + " | " + max);

         

        }

        static long RerChainCnt(long num)
        {
           
            long cnt = 1;

            while (num > 1)
            {
                if (num % 2 == 0)
                {
                    num = num / 2;
                    
                  
                }
                else
                {
                    num = (num * 3) + 1;
                  
                   
                }
                cnt++;

            }
            
            return cnt;

        }
    }
}
