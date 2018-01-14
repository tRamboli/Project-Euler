using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> a = new List<long>();
            a.Add(1);
            a.Add(2);
            a.Add(3);
            int i = 2;
            

            while ((a[i - 1] + a[i - 2]) < 4000000)
            {
                i++;
                a.Add (a[i - 1] + a[i - 2]);
         
            }
            a.RemoveAt(a.Count - 1);

            long d = 0;
            for ( i = 0; i < a.Count ; i++)
            {
                if (a[i] % 2 == 0)
                {
                    d += a[i];
                }
                
            }
            
            Console.WriteLine(d);
        
        }
    }
}
