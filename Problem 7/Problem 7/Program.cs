using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_7
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = 0;
            int cnt = 0;
            while (cnt <= 10001)
            { 
                num++;
                if (ifprime(num))
                {
                    
                    cnt++;
                }
               
            }
            Console.WriteLine(num);


        }

        static bool ifprime(long  num)
        {
            for (int i = 2; i <= num/2; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;

        }

    }
}
