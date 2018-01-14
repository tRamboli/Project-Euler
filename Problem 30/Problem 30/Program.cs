using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_30
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 10; i <600000; i++)
            {
                string st = i.ToString();
                if (Ifsum(st))
                    sum += int.Parse(st);


            }
            Console.WriteLine(sum);
        }

        static bool Ifsum(string  num)
        {
            double sum = 0;
            for (int i = 0; i < num.Length ; i++)
            {
                sum+=Math.Pow (double .Parse (num[i].ToString ()),5);

            }

            if (sum == int.Parse(num))
                return true;
            else
                return false;



        }
       
    }
}
