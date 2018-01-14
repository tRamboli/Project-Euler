using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int Prime = 1;
            int divNo;
            double total = 2;
            bool isPrime = true;
            while (Prime < 1000000)
            {
                Prime += 2;
                divNo = 3;
                isPrime = true;
                double sqrt = Math.Sqrt(Prime);
                while (divNo <= sqrt && isPrime == true)
                {
                    if (Prime % divNo == 0)
                    {
                        isPrime = false;
                    }
                    divNo += 2;

                }
                if (isPrime == true)
                    total += Prime;
            }
            Console.Out.WriteLine(total.ToString());
            Console.In.ReadLine();
        }
           
    }
}
