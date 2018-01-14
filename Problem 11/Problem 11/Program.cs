using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Problem_11
{
    class Program
    {
        private static  int N =20;
        static void Main(string[] args)
        {

            int[,] arr = readInput(@"c:\p11.txt");

         

            int[] a = { Horizontal_Sum(arr), Vertical_Sum(arr), DiagonRight_Sum(arr),DiagonLeft_Sum(arr) };
            int max=-1;
            for (int i = 0; i < a.Length; i++)
			{
                if(a[i]>max)
                    max =a[i];
			 
			}
           
            Console.WriteLine (max);
       

        }

        static int DiagonLeft_Sum(int[,] a)
        {
            int max = -1;
            int sum = 1;

            for (int i = 0; i < N; i++)
            {

                for (int j = 0; j < N; j++)
                {
                    if (i <= N - 4 && j >= 4)
                    {
                        for (int s = 0; s < 4; s++)
                        {
                            sum *= a[i + s, j - s];

                            
                        }

                        if (sum > max)
                            max = sum;
                        sum = 1;
                    }
                }
            }
            return max;

        }


        static int DiagonRight_Sum(int[,] a)
        {
            int max = -1;
            int sum = 1;

            for (int i = 0; i < N; i++)
            {

                for (int j = 0; j < N; j++)
                {
                    if (i <= N - 4 && j<= N-4 )
                    {
                        for (int s = 0; s < 4; s++)
                        {
                            sum *= a[i + s, j+s];
                            
                        }

                        if (sum > max)
                            max = sum;
                        sum = 1;
                    }
                }
            }
            return max;

        }

        static int Vertical_Sum(int[,] a)
        {
            int max = -1;
            int sum = 1;

            for (int i = 0; i < N; i++)
            {

                for (int j = 0; j < N; j++)
                {
                    if (i <= N - 4)
                    {
                        for (int s = 0; s < 4; s++)
                        {
                            sum *= a[i+s, j];
                        
                        }

                        if (sum > max)
                            max = sum;
                        sum = 1;
                    }
                }
            }
            return max;

        }

        static int Horizontal_Sum(int[,] a)
        {
            int max = -1;
            int sum = 1;

            for (int i = 0; i <N ; i++)
            {

                for (int j = 0; j < N; j++)
                {
                    if (j <= N - 4)
                    {
                        for (int s = 0; s < 4; s++)
                        {
                            sum *= a[i, j + s];
                            
                        }

                        if (sum > max)
                            max = sum;
                        sum = 1;
                    }
                }
            }
            return max;
        }

        private static int[,] readInput(string filename)
        {
            int lines = 0;
            string line;
            string[] linePieces;
          

            StreamReader r = new StreamReader(filename);
            while (r.ReadLine() != null)
            {
                lines++;
            }

            int[,] inputSquare = new int[lines, lines];
            r.BaseStream.Seek(0, SeekOrigin.Begin);

            int j = 0;
            while ((line = r.ReadLine()) != null)
            {
                linePieces = line.Split(' ');
                for (int i = 0; i < linePieces.Length; i++)
                {
                    inputSquare[j, i] = int.Parse(linePieces[i]);
                }
                j++;
            }

            r.Close();

            return inputSquare;
        }
    }
}
