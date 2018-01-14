using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
          

            long d = 100000;
            long num;
            long s = 0;
            while (d<1000000)
            {
                if (Ifpol(d))
                {
                    for (int i = 100; i < 1000; i++)
                    {
                        if (d % i == 0)
                        {
                            num = d / i;

                            if (num.ToString().Length == 3)
                            {
                                s = num * i;
                            }
                        }

                    }
                }

                d++;
            }
            Console.WriteLine(s);

        }

        static bool Ifpol (long num)
        {
            string s = num.ToString();

            for (int i = 0; i < s.Length ; i++)
            {

                if (s[i] != s[s.Length - 1 - i])
                    return false;
            }
            return true;
        }
    }
}
