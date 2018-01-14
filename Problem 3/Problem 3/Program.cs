using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = 600851475143;
           

            long i =2;
            long d = 1;

            while (d < num)
            {
                if (num % i == 0)
                {
                    d *= i;
                    Console.WriteLine("i| "+i);
                  
                }
                i++;

            }
          
          

        }
    }
}
