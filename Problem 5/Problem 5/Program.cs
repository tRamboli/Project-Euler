using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while (!Ifdev(num))
            {
                num++;
            }
            Console.WriteLine(num);
        }


        static bool Ifdev(int num)
        {
            for (int i = 1; i < 21; i++)
            {
                if ((num % i) != 0)
                    return false;
            }
            return true;

        }
    }
}
