using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_16
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 2;

            for (int i = 1; i <= 1000; i++)
            {
                sum *= i;   
            }

            //string st = sum.ToString();
            //for (int i = 0; i < st.Length; i++)
            //{
            //    sum += int.Parse(st[i].ToString ());
                
            //}
            Console.WriteLine(sum);
        }
    }
}
