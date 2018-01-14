using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_28
{
    class Program
    {
        static int N = 11;
        static int cnt = 2;
        static int[] Lastpt = new int [2];
        static  int[,] a = new int[N, N];
        static void Main(string[] args)
        {

            a[((N+1)/2)-1,((N+1)/2)-1]=1;
       

            GoRight(5,5,5);
            PrintArr();
            PrintLst();
            for (int i = 0; i < N; i++)
            {

                
            }

        }

        static void GoRight(int p, int b, int k)
        {
            int n=0;
            for (int i = 1; i <= k; i++)
            {
                n = b + i;
                a[p, n] = cnt;
                
                cnt++;
            }
            Lastpt[0] = p;
            Lastpt[1] = n;

        }
        static void GoLeft(int p, int b, int k)
        {

        }
        static void GoUp(int p, int b, int k)
        {

        }
        static void GoDown(int p, int b, int k)
        {

        }

        static void PrintArr()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(a[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
        static void PrintLst()
        {
            Console.WriteLine("i:{0}. j:{1}", Lastpt[0].ToString(), Lastpt[1].ToString());
           
        }
    }
}
