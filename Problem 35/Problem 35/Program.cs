using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_35
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        static bool Ifrot(long num)
        {
            
            string st=num.ToString();
            char[] a = new char[st.Length];
          
            for (int i = 0; i < (st.Length)*(st.Length); i++)
            {
                a[i] = st[st.Length - i];

                
            }
        }

        static bool Ifprome(long num)
        {
            for (int i = 2; i < Math.Sqrt (num); i++)
            {
                if (num % i == 0)
                    return false;
                
            }

            if (num == 2)
                return true;

            return true;
        }
    }
}
